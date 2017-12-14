var io = require("socket.io")(8000);
var partidasDisponibles = [];
var partidasCreadas = 1;
var socketCliente;

io.on("connection", function(socket){
	socketCliente = socket;
	console.log("Cliente conectado");
	var partidasJson = JSON.stringify(partidasDisponibles);
	socket.emit("actualizarTablaPartidas", partidasJson);
	console.log(partidasJson);

	socket.on("nuevaPartida", crearNuevaPartida);
	socket.on("unirsePartida", unirseAPartida);
	socket.on("eliminarPartida", eliminarPartida);
});

/**
 * Método asociado al evento "nuevaPartida", crea una nueva sala para la partida que recibe y la guarda en el arreglo de partidas disponibles
 * @param {JSON} partidaJSON un objeto partida en formato JSON que contiene el nombre del jugador que creó la partida
 */
function crearNuevaPartida(partidaJSON){
	var partida = JSON.parse(partidaJSON);
	partida.IdPartida = partidasCreadas;
	partidasCreadas++;
	partidasDisponibles.push(partida);

	this.join(partida.IdPartida.toString()); //Hacer que el socket se una a la sala
	var partidasJSON = JSON.stringify(partidasDisponibles);
	console.log(partidasJSON);
	socketCliente.broadcast.emit("actualizarTablaPartidas",partidasJSON);
	socketCliente.emit("actualizarTablaPartidas", partidasJSON);
}

/**
 * Método asociado al evento "unirsePartida", hace que el socket del cliente se una a la sala que recibe como parámetro
 * @param {JSON} partidaJSON la partida a la que se va a unir el socket, en formato JSON 
 */
function unirseAPartida(partidaJSON){
	var partida = JSON.parse(partidaJSON);

	buscarPartida(partida);
	
	this.join(partida.IdPartida.toString());
	quitarPartidasLlenas();

	var partidasJSON = JSON.stringify(partidasDisponibles);
	socketCliente.broadcast.emit("actualizarTablaPartidas",partidasJSON);
	socketCliente.emit("actualizarTablaPartidas",partidasJSON);
	console.log(partidasJSON);

	//emitir evento solo a los que se encuentren en la sala
	io.sockets.in(partida.IdPartida.toString()).emit("mostrarTablero", partidaJSON);
	//io.sockets.in(partida.IdPartida.toString()).emit("comenzarJuego", partidaJSON);
}

/**
 * Quita las salas que están llenas(con 2 jugadores dentro) del arreglo de partidas disponibles
 */
function quitarPartidasLlenas(){
	for(i = 0; i < partidasDisponibles.length; i++){
		if(partidasDisponibles[i].usuariosDentro == 2){
			console.log(partidasDisponibles[i].usuariosDentro);
			partidasDisponibles.splice(i, 1);
		}
	}
}

/**
 * Busca una partida y la establece como llena, evita que más de dos jugadores se unan a la misma partida
 * @param {partida} Un objeto partida que se va a buscar en el arreglo de partidas disponibles
 */
function buscarPartida(partida){
	for(i = 0; i<partidasDisponibles.length; i++){
		if(partidasDisponibles[i].IdPartida == partida.IdPartida){
			partidasDisponibles[i].usuariosDentro = 2;
		}
	}
}


/**
 * Elimina la partida del usuario que se recibe como parámetro
 * @param {JSON} Un objeto JSON que representa un usuario
 */
function eliminarPartida(usuarioJSON){
	console.log(usuarioJSON);
	var usuario = JSON.parse(usuarioJSON);
	for(i = 0; i < partidasDisponibles.length; i++){
		var nombreJugadorPartida = partidasDisponibles[i].NombreJugador1;
		var nombreUsuario = usuario.NombreUsuario;
		if(nombreJugadorPartida === nombreUsuario){
			partidasDisponibles.splice(i, 1);
		}
	}
	var partidasJSON = JSON.stringify(partidasDisponibles);
	console.log(partidasJSON);
	socketCliente.broadcast.emit("actualizarTablaPartidas",partidasJSON);
}
