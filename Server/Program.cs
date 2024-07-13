﻿using System.Net;
using System.Net.Sockets;
using DataAccess.Context;

var dbContext = new MyDbContext();

// make socket TCP listener
var server = new Server.Server();

// start listening
Console.WriteLine("Server is running...");

while (true)
{
    Console.WriteLine("Waiting for connection...");
    server.Receive();
    Console.WriteLine("Connection received");
}