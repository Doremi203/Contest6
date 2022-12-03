using System;

[Flags]
public enum Permissions
{
    
    Default=0b000000001,
    UserRead = 0b0000000010,
    UserWrite = 0b0000000100,
    UserExecute = 0b0000001000,
    GroupRead = 0b0000010000,
    GroupWrite = 0b0000100000,
    GroupExecute = 0b0001000000,
    EveryoneRead = 0b0010000000,
    EveryoneWrite = 0b0100000000,
    EveryoneExecute = 0b1000000000
}