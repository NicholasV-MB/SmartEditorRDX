function mainShowCampata3D(){
	// Assegnazione variabili
	// Input da/verso processo
	var input_Altezza = document.getElementById("RDVAR_Altezza");
	var input_Lunghezza = document.getElementById("RDVAR_Lunghezza");
	var input_Profondita = document.getElementById("RDVAR_Profondita");
	var input_Livelli = document.getElementById("RDVAR_Livelli");
	var input_AltezzeLivelli = document.getElementById("RDVAR_AltezzeLivelli");
	var input_Oggetto= document.getElementById("RDVAR_Oggetto");
	var input_LivelloDiCarico = document.getElementById("RDVAR_LivelloDiCarico");
	var input_Posizione= document.getElementById("RDVAR_Posizione");
	
	// Variabili Globali
	var Canvas3D = document.getElementById("Canvas3D");
	Canvas3D.innerWidth = 500;
	Canvas3D.innerHeight = 500;
	
	var montante_material = new THREE.MeshBasicMaterial( {color: 0x0000FF, transparent:true, alphaTest:1} );
	var corrente_material = new THREE.MeshBasicMaterial( {color: 0xFFFF00, transparent:true, alphaTest:1} );
	var traversino_material = new THREE.MeshBasicMaterial( {color: 0x808080, transparent:true, alphaTest:1} );
	var colori = ["Verde", "Ocra", "Rosso"];
	var interventi = ["Monitorare", "Sostiuire", "Altro"];
	var montante_name = "MONTANTE";
	var corrente_name = "CORRENTE";
	var traversino_name = "TRAVERSINO";
	var scene3D, camera3D, renderer3D, controls3D, axesHelper;
	var spalle = [];
	var all_objects = [];
	var idx_annotation = 1;
	var colors = {
		"Verde": 0x00ff00,
		"Ocra": 0xDAA520, //0xaea04b,
		"Rosso": 0xff0000
	}

	
	// Funzione per modificare la visualizzazione quando la finestra viene ridimensionata
	function onResize() {
		Canvas3D.innerWidth = window.innerWidth;
		Canvas3D.innerHeight = window.innerHeight;
		camera3D.aspect = Canvas3D.innerWidth/Canvas3D.innerHeight;
		renderer3D.setSize( Canvas3D.innerWidth, Canvas3D.innerHeight );
		camera3D.updateProjectionMatrix();
	}

	
	
	// Avvio funzioni prncipali del canvas3D
	Start3D();
	Update3D();
	

	// funzione che crea la visualizzazione 3D all'avvio della pagina
	function Start3D(){
		// scena
		scene3D = new THREE.Scene();
		scene3D.name= "Scene3D";
		// camera
		camera3D = new THREE.PerspectiveCamera( 100, Canvas3D.innerWidth / Canvas3D.innerHeight, 0.00001, 10000000000 );
		camera3D.position.set(2500,4500,5000);
		camera3D.updateProjectionMatrix();
		camera3D.name = "Camera3D";
		scene3D.add(camera3D);
		// render	
		renderer3D = new THREE.WebGLRenderer( {antialias: true} );
		renderer3D.setSize( Canvas3D.innerWidth, Canvas3D.innerHeight );
		renderer3D.setClearColor( 0x4f5f80 );
		renderer3D.setPixelRatio( Canvas3D.devicePixelRatio );
		Canvas3D.appendChild( renderer3D.domElement );
		// controllo dei moviementi della camera
		controls3D = new THREE.OrbitControls( camera3D, renderer3D.domElement  );
		controls3D.addEventListener( 'change', Render3D );
		controls3D.target.set(0, 0, 0);
		controls3D.update();
		// helper per conoscere l'orientamento degli assi
		axesHelper = new THREE.AxesHelper( 50000 );
		axesHelper.name = "axesHelper";
		scene3D.add( axesHelper );
		//restore_annotations();
		var lunghezza = parseInt(input_Lunghezza.value);
		var altezza = parseInt(input_Altezza.value);
		var profondita = parseInt(input_Profondita.value);
		var livelli = parseInt(input_Livelli.value);
		var altezzeLivelli_str = input_AltezzeLivelli.value;
		var altezzeLivelli_arr = altezzeLivelli_str.split(";");
		var altezzeLivelli = [];
		altezzeLivelli_arr.forEach( al =>{
			altezzeLivelli.push(parseInt(al));
		});
		altezzeLivelli.sort();
		
		// Chiamata a funzione che costruisce la campata 3D con oggettu abse threejs
		showCampata3D(lunghezza, profondita, altezza, livelli, altezzeLivelli);
		
		// in aternativa utilizzare il loader STL per caricare un modello già esistente https://github.com/mrdoob/three.js/blob/dev/examples/webgl_loader_stl.html
	}
	
	

	// Funzione di update della scena 3D
	function Update3D(){
		//evaluate_annotations();
		controls3D.update();
		Render3D();
		requestAnimationFrame( Update3D );
	}
	
	// Funzione di render della scena 3D
	function Render3D(){
		renderer3D.render(scene3D, camera3D);
	}



	// Funzione per visualizzare la campata selezionata in 3D
	function showCampata3D(lunghezza, profondita, altezza, livelli, altezzeLivelli){
		//clear3DScene();
		var in_corr = true;
		var lr = "Sx";
		var bf = "Back";
		var points = [0, 0, lunghezza, 0, lunghezza, profondita, 0, profondita];
		for (var idx = 0; idx<=(points.length-2); idx=idx+2){
			if(idx==2){
				lr="Dx";
			} else if(idx==4){
				bf="Front";
			} else if (idx==6){
				lr="Sx";
			}
			var montante = drawMontantePP(points[idx], altezza, points[idx+1]);
			montante.name = montante_name+"-"+bf+"-"+lr;
			scene3D.add(montante);
			var s_p = new THREE.Vector3(points[idx], 0, points[idx+1]);
			var e_p = new THREE.Vector3(points[idx+2], 0, points[idx+3]);
			var h_min  = 50;
			
			altezzeLivelli.sort();
			var idxLiv = 1;
			altezzeLivelli.forEach(hLiv =>{
				if(in_corr==true){
					var corr = drawCorrentePP(s_p, e_p, hLiv);
					corr.name = corrente_name+"-"+bf+"-"+idxLiv;
					scene3D.add(corr);
				} else {
					if ( idxLiv==1){
						var to = drawTraversinoOrPP(s_p, e_p, h_min);
						to.name = traversino_name+"-Orizzontale-"+lr+"-"+0;
						scene3D.add(to);
					}
					if(idx==6){
						var td = drawTraversinoDiagPP(s_p, e_p, hLiv, h_min);
					} else {
						var td = drawTraversinoDiagPP(e_p, s_p, hLiv, h_min);
					}
					td.name = traversino_name+"-Diagonale-"+lr+"-"+(idxLiv-1);
					scene3D.add(td);
					var to = drawTraversinoOrPP(s_p, e_p, hLiv);
					to.name = traversino_name+"-Orizzontale-"+lr+"-"+idxLiv;
					scene3D.add(to);
					h_min = hLiv;
					
				}
				idxLiv += 1;
			});
			in_corr = ! in_corr;
		}
	}

	// Funzione per disegnare una spalla del portapallet
	function drawMontantePP(pos_x, h, pos_z){
		var geometry = new THREE.BoxGeometry( 100, h, 100 );
		var montante = new THREE.Mesh( geometry, montante_material );
		montante.position.set(pos_x, h/2, pos_z);
		return montante;
	}
	
	// Funzione per disegnare un corrente del portapallet 
	function drawCorrentePP(pos_s, pos_e, h){
		var dim = pos_s.distanceTo(pos_e)-100;
		var geometry = new THREE.BoxGeometry( dim, 100, 100 );
		var corrente = new THREE.Mesh( geometry, corrente_material );
		corrente.position.set((pos_s.x+pos_e.x)/2, h, (pos_s.z+pos_e.z)/2);
		return corrente;
	}
	
	// Funzione per disegnare un traversino orizzontale
	function drawTraversinoOrPP(pos_s, pos_e, h){
		var dim = pos_s.distanceTo(pos_e)-100;
		var geometry = new THREE.CylinderGeometry( 30, 30, dim, 32 );
		var traversinoOr = new THREE.Mesh( geometry, traversino_material );
		traversinoOr.position.set((pos_s.x+pos_e.x)/2, h, (pos_s.z+pos_e.z)/2);
		traversinoOr.rotateX(90*Math.PI/180);
		return traversinoOr;
	}
	
	// Funzione per disegnare un traversino diagonale 
	function drawTraversinoDiagPP(pos_s, pos_e, h_max, h_min){
		var dim = Math.sqrt( Math.pow(pos_s.distanceTo(pos_e)-100, 2) + Math.pow(h_max-h_min-100, 2) );
		var geometry = new THREE.CylinderGeometry( 30, 30, dim, 32 );
		var traversinoDiag = new THREE.Mesh( geometry, traversino_material );
		traversinoDiag.position.set((pos_s.x+pos_e.x)/2, (h_max+h_min)/2, (pos_s.z+pos_e.z)/2);
		var theta = Math.atan(
			(h_max-h_min)/pos_s.distanceTo(pos_e)
		);
		var y = h_max-(dim/(2*Math.cos((Math.PI/2)-theta)))-100;
		traversinoDiag.lookAt(pos_e.x, y, pos_e.z );
		return traversinoDiag;
	}
	
	
	// Funzione per popolare l'array "all_objects" con tutti gli oggetti della campata selezionata 
	function get_all_objects(){
		all_objects = [];
		scene3D.traverse(child => {
			if(child.name!=camera3D.name && child.name!=axesHelper.name && child.name!="Scene3D"){
				child.geometry.computeBoundingBox();
				child.geometry.computeBoundingSphere();
				all_objects.push(child);
			}
		});
	}
	
	// Funzione per disegnare una annotazione in corrispondenza dell'oggetto selezionato 
	function drawAnnotation(x, y, z){
		scene3D.remove(scene3D.getObjectByName("Annotazione"));
		geometry = new THREE.SphereGeometry( 100, 32, 32 );
		var material = new THREE.MeshBasicMaterial( {color: 0x00FF00, transparent:true} );
		var sphere = new THREE.Mesh( geometry, material );
		sphere.name = "Annotazione";
		sphere.position.set(
			x,
			y, 
			z
		);
		scene3D.add(sphere);
	}
	
	
	
	// Gestione eventi mouse nel canvas 3D
	// Variabili
	var raycaster3D = new THREE.Raycaster();
	var mouse3D = new THREE.Vector2();
	var point_found = false;
	
	
	// Eventi
	// Movimento del puntatore
	Canvas3D.addEventListener("pointermove", event => {
		mouse3D.x =  ((event.clientX-Canvas3D.getBoundingClientRect().left) / Canvas3D.innerWidth ) * 2 - 1;
		mouse3D.y = - (( event.clientY-Canvas3D.getBoundingClientRect().top) / Canvas3D.innerHeight ) * 2 + 1;
		raycaster3D.setFromCamera(mouse3D, camera3D);
	});

	// Pressione click mouse
	Canvas3D.addEventListener("pointerdown", () => {
		get_all_objects();
		var intersects = raycaster3D.intersectObjects(all_objects);
		if (intersects.length > 0) {
			var arr_name = intersects[0].object.name.split("-");
			if (intersects[0].object.name.startsWith(montante_name)==false){
				input_LivelloDiCarico.value = arr_name.pop();
			} else {
				input_LivelloDiCarico.value = "";
			}
			input_Oggetto.value = arr_name.join('-');
			var pos = intersects[0].point;
			pos.x = Math.round(pos.x);
			pos.y = Math.round(pos.y);
			pos.z = Math.round(pos.z);
			input_Posizione.value = JSON.stringify(pos);
			drawAnnotation(pos.x, pos.y, pos.z);
		}
	} );
	
	
	// Rilascio click mouse
	Canvas3D.addEventListener("pointerup", () => {
		if( point_found==true ){
			controls3D.enabled = true;
			point_found=false;
		}
	} );
}

// FUNZIONI PER EDIT O CHE POTREBBERO ESSERE UTILI

	// Funzione per rigenare le annotazioni dal valore passato dal processo
	/*function restore_annotations(){
		get_trains();
		all_campate.forEach(c =>{
			var treno = c.name.split("-")[0];
			var campata = c.name.split("-")[1];
			for (var ann of JSON.parse(input_Annotations.value)){
				if(treno == ann.Treno && campata == ann.Campata){
					if ( c.userData.Annotazioni == undefined) { c.userData.Annotazioni = {} }
					var oggetto_name = c.name+"-"+ann.Oggetto;
					c.userData.Annotazioni[ann.ID] = {
						"Oggetto": { "name": oggetto_name},
						"id": ann.ID,
						"Livello": ann.Livello,
						"posizione": {
							"x": ann.Posizione.x,
							"y": ann.Posizione.y,
							"z": ann.Posizione.z,
							"parentID": ann.ID
						},
						"Intervento": ann.Intervento,
						"Nota": ann.Nota,
						"Foto": ann.Foto,
						"Elimina": EliminaAnnotazione,
					}	
					var material = new THREE.MeshBasicMaterial( {color: colors[ann.Livello], transparent:true} );
					campata_selected = c;
					train_selected = c.parent;
					showAnn2D(material);
					campata_selected=undefined;
					train_selected=undefined;
				}
			}	
		});
	}*/
	
	// Funzione per disegnare una annotazione in corrispondenza dell'oggetto selezionato 
	/*function drawAnnotation(sets){
		scene3D.remove(scene3D.getObjectByName("Annotazione "+sets.id));
		geometry = new THREE.SphereGeometry( 100, 32, 32 );
		var material = new THREE.MeshBasicMaterial( {color: colors[sets.Livello], transparent:true} );
		var sphere = new THREE.Mesh( geometry, material );
		sphere.name = "Annotazione "+sets.id;
		sphere.position.set(
			sets["posizione"].x,
			sets["posizione"].y, 
			sets["posizione"].z
		);
		scene3D.add(sphere);
		showAnn2D(material);
	}*/
	
	// Funzione per valorizzare le annotazioni da restituire al processo
	/*function evaluate_annotations(){
		get_trains();
		var all_annotazioni = [];
		all_campate.forEach(c=>{
			if (c.userData.Annotazioni != undefined &&  Object.keys(c.userData.Annotazioni).length>0){
				for ( var key in c.userData.Annotazioni ){
					var ann = c.userData.Annotazioni[key];
					var nome_oggetto = ann.Oggetto.name;
					var my_ann_json = {
						"Treno": nome_oggetto.split("-")[0],
						"Campata": nome_oggetto.split("-")[1],
						"Oggetto": nome_oggetto.split("-").slice(2).join("-"),
						"ID": ann.id,
						"Livello": ann.Livello,
						"Posizione": {
							"x": Math.round(ann.posizione.x),
							"y": Math.round(ann.posizione.y),
							"z": Math.round(ann.posizione.z),
						},
						"Intervento": ann.Intervento,
						"Nota": ann.Nota,
						"Foto": ann.Foto,
					}
					all_annotazioni.push(my_ann_json);
				}
			}
		});
		input_Annotations.value = JSON.stringify(all_annotazioni);
	}*/
	
	// Funzione per ripulire la scena 3D da tutti gli elementi diversi da camera e helper degli assi
	/*function clear3DScene(){
		var to_remove = [];
		scene3D.children.forEach(child =>{
			if(child.name!=camera3D.name && child.name!=axesHelper.name){
				to_remove.push(child);
			}
		});
		to_remove.forEach(child => {
			scene3D.remove(child);
		});
	}*/