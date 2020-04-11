# Videosync
A video player with built in file transfer and chat - or that's the idea

## Resources

- https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.mediaelement.position?view=netframework-4.8
- https://docs.microsoft.com/en-us/dotnet/framework/network-programming/asynchronous-server-socket-example
- https://www.c-sharpcorner.com/article/socket-chat/
- https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.udpclient?view=netframework-4.8
- https://gist.github.com/zziuni/3741933
- https://www.codeproject.com/Articles/18492/STUN-Client

## Overview

- Everyone gets their STUN results and if it all checks out they link up
- Everyone does a few ping calculations, to get average ping to eachother, then send their tick and store the tick difference
- Every packet has tick, type, parameters, data
- File is chopped up then sent in data chunks from "host" to clients and between clients, each confirming their hash as it completes. The further it goes, the more the host just tells clients to fetch from other clients. Once everyone is synced and ready for playback signal is sent to listen for instructions.
- All the while, chat is available through the channel. Chat is shouted to all clients. Each client sends the 5 previous chats received with each chat, differences are lined up that way.
- Once playback is ready, initial state is Pause at 0. When any client presses play/pause (and rewind/forward is only available paused) they include the time code and the tick. On play, try to sync up with client current time using diff calculation and resume playback

## More Overview

ConnectorClass
	- GetEndpoint
		- STUNs example
	- ConnectNeighbor (Endpoint)
		- Using passed Endpoint, connect to Endpoint
 		- return connection
	- SendMessage (Message)
		- Serialize message
		- ForEach Neighbor
			- Send message			
	- ReceiveMessage
		- deserialize message
		- return
		
