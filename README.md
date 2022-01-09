# Oculus Manager
Manage (see if they exist, and kill them) your Oculus Background Processes with ease.

## What? Why?
Oculus' (proprietary) Software, on windows, keeps drivers and helper processes running in the background, even after closing the app.<br/>
It additionally starts the driver on system startup, which makes no sense if you don't use your headset 24/7, and even then, starting the app automatically starts this driver anyway.<br/>
This driver starts within seconds, so why is it running in the background 24/7?

The answer is likely Facebook/Meta tracking you using it.

## What is Oculus Manager
Oculus Manager is a simple process to kill all (known) Oculus-related processes with the click of 2 buttons (start program, click `Kill Oculus`).<br/>
This is to save resources, and keep your Linux ISOs private.

## How do I install Oculus Manager?
Simply download the [Installer](), and run it.<br/><br/>
Windows (>8) will likely prompt you with:<br/>
![Windows Protected your PC](https://cdn.cbt.wiki/Generic_VyIwCFSJ9WHJicLcxmHqrEaOG)<br/>
This is normal, since I did not "digitally sign" the installer, or the program, since I don't have a widely trusted certificate, and don't want to pay >$200/year for one.<br/>
Simply dismiss the notification by clicking `Read More`, then `Run Anyway`.

## Why do I need administrative rights? (installer & app)
For the installer, it's to install it for all users.<br/>
For the app, it's to have permissions to kill Oculus' services.

---

### If you notice that Oculus starts itself again,...
...or you see other oculus processes running after pressing `Kill Oculus`, please [create an issue](https://github.com/MokiyCodes/OculusManager/issues/new)
