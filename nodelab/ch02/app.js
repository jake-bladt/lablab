const http = require('http');
http.createServer(function (req, res) {
    res.writeHead(200, { 'content-type': 'text/plain' });
    res.end('=^..^=\n');
}).listen(8124, '127.0.0.1');
console.log('Server running at 127.0.0.1:8124');
