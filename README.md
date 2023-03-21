# MedCart Protocol Test

### Requirements
- .NET 6.0
- Packages *System.IO.Ports* and *EasyModbusTCP.NETCore*

### Description
This project shows how to interface the MedCart using Modbus RTU protocol.  This is NOT a full function project.  That is, it can only do the following:
- Upon connect to serial port, it reads the board and firmware versions from the MedCart's controller.
- It sends *OPEN* command to a selected drawer solednoid.

### Suggestions
- Add a timer to read system status every *N* seconds (or *NNN* milliseconds)
- Solenoids can be opened more than one at the same time, although not recommended.
- Set number of retries to 2 so it won't take too long to realize communication problems, but make it more than 1 so it has a chance to retry.

### Notes
- Upon receiving a solenoid command, the open signal is active for 0.5 seconds.  After inactivated, it will not be available for another 2 seconds.
  This is to protect the solenoids from overheating.
- Bluetooth responses may be delayed sometimes.  USB serial is more prompt.
