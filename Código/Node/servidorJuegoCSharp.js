var io = require("socket.io")(9000);
var socketCliente;

io.on("connection", function(socket){
	socketCliente = socket;
	console.log("Jugador conectado");

	socket.on("comenzarJuego", comenzarJuego);
	socket.on("realizarTiro", realizarTiro);
});

function comenzarJuego(partidaJSON){
	var partida = JSON.parse(partidaJSON);
	console.log(partidaJSON);
	this.join(partida.IdPartida.toString());
	io.sockets.in(partida.IdPartida.toString()).emit("asignarTurnos", partidaJSON);
}

function realizarTiro(jugadaJSON){
	console.log(jugadaJSON);
	var jugada = JSON.parse(jugadaJSON);
	io.sockets.in(jugada.IdPartida.toString()).emit("pintarTiro", jugadaJSON);
}