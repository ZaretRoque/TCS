var io = require("socket.io")(8500);
var socketCliente;

io.on("connection", function(socket){
	socketCliente = socket;
	console.log("Jugador conectado");

	socket.on("comenzarJuego", comenzarJuego);
	socket.on("realizarTiro", realizarTiro);
	socket.on("abandonarPartida", abandonarPartida);
});

/**
 * Responsable de unir a los jugadores a la partida en red, invoca al evento asignar turnos
 * @param {JSON} Un objeto JSON que representa la partida a la que se van a unir
 */
function comenzarJuego(partidaJSON){
	var partida = JSON.parse(partidaJSON);
	console.log(partidaJSON);
	this.join(partida.IdPartida.toString());
	io.sockets.in(partida.IdPartida.toString()).emit("asignarTurnos", partidaJSON);
}

/**
 * Se utiliza para envíar los tiros de cada jugador a través de la red
 * @param {JSON} Un objeto JSON que representa el tiro del jugador
 */
function realizarTiro(jugadaJSON){
	console.log(jugadaJSON);
	var jugada = JSON.parse(jugadaJSON);
	io.sockets.in(jugada.IdPartida.toString()).emit("pintarTiro", jugadaJSON);
}

/**
 * Se invoca cuando un jugador abandona la partida
 * @param {JSON} Un objeto jugada con el Id de la partida y el turno del jugador, se envía a todos los jugadores
 * para contabilizar como partida ganada o perdida
 */
function abandonarPartida(jugadaJSON){
	var jugada = JSON.parse(jugadaJSON);
	io.sockets.in(jugada.IdPartida.toString()).emit("jugadorAbandonaPartida", jugadaJSON);
}