Simple Linux service that runs and logs stuff, and cleanly exits.

Also shows how to publish as a single self-executing file

To use....

1. Publish
2. Go to output directory ([project Dir]/DnsServer/bin/Release/net8.0/linux-x64/publish)
3. sudo cp DnsServer.service /etc/systemd/system/
4. sudo systemctl enable DnsServer.service
5. sudo systemctl start DnsServer.service
6. sudo systemctl status DnsServer.service
   
    Will see...

   phillip@PDAero-Ubuntu:~/source/c#/DnsServer/DnsServer/bin/Release/net8.0/linux-x64/publish$ sudo systemctl status  DnsServer.service
   ● DnsServer.service - Test service that does nothing but log stuff.
   Loaded: loaded (/etc/systemd/system/DnsServer.service; enabled; vendor preset: enabled)
   Active: active (running) since Mon 2024-07-22 11:38:53 AEST; 23s ago
   Main PID: 14048 (DnsServer)
   Tasks: 14 (limit: 76881)
   Memory: 13.5M
   CPU: 451ms
   CGroup: /system.slice/DnsServer.service
   └─14048 /home/phillip/source/c#/DnsServer/DnsServer/bin/Release/net8.0/linux-x64/publish/DnsServer

Jul 22 11:39:13 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:13 +10:00
Jul 22 11:39:14 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] My Test Service running at: 07/22/2024 11:39:14 +10:00
Jul 22 11:39:14 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] A warning from My Test Service at: 07/22/2024 11:39:14 +10:00
Jul 22 11:39:14 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:14 +10:00
Jul 22 11:39:15 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] My Test Service running at: 07/22/2024 11:39:15 +10:00
Jul 22 11:39:15 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] A warning from My Test Service at: 07/22/2024 11:39:15 +10:00
Jul 22 11:39:15 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:15 +10:00
Jul 22 11:39:16 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] My Test Service running at: 07/22/2024 11:39:16 +10:00
Jul 22 11:39:16 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] A warning from My Test Service at: 07/22/2024 11:39:16 +10:00
Jul 22 11:39:16 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:16 +10:00

7. sudo systemctl stop DnsServer.service
8. sudo systemctl status DnsServer.service

    Will See...

   ○ DnsServer.service - Test service that does nothing but log stuff.
   Loaded: loaded (/etc/systemd/system/DnsServer.service; enabled; vendor preset: enabled)
   Active: inactive (dead) since Mon 2024-07-22 11:39:28 AEST; 2s ago
   Process: 14048 ExecStart=/home/phillip/source/c#/DnsServer/DnsServer/bin/Release/net8.0/linux-x64/publish/DnsServer (code=exited, status=0/SUCCESS)
   Main PID: 14048 (code=exited, status=0/SUCCESS)
   CPU: 592ms

Jul 22 11:39:27 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] My Test Service running at: 07/22/2024 11:39:27 +10:00
Jul 22 11:39:27 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] A warning from My Test Service at: 07/22/2024 11:39:27 +10:00
Jul 22 11:39:27 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:27 +10:00
Jul 22 11:39:28 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] My Test Service running at: 07/22/2024 11:39:28 +10:00
Jul 22 11:39:28 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] A warning from My Test Service at: 07/22/2024 11:39:28 +10:00
Jul 22 11:39:28 PDAero-Ubuntu DnsServer[14048]: DnsServer.Worker[0] An error from My Test Service at: 07/22/2024 11:39:28 +10:00
Jul 22 11:39:28 PDAero-Ubuntu systemd[1]: Stopping Test service that does nothing but log stuff....
Jul 22 11:39:28 PDAero-Ubuntu DnsServer[14048]: Microsoft.Hosting.Lifetime[0] Application is shutting down...
Jul 22 11:39:28 PDAero-Ubuntu systemd[1]: DnsServer.service: Deactivated successfully.
Jul 22 11:39:28 PDAero-Ubuntu systemd[1]: Stopped Test service that does nothing but log stuff..

9. sudo systemctl disable DnsServer.service
10. sudo rm /etc/systemd/system/DnsServer.service

    