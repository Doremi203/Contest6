using System;

[Flags]
public enum Permissions
{
    Default = 1 << 0,
    UserRead = 1 << 1,
    UserWrite = 1 << 2,
    UserExecute = 1 << 3,
    GroupRead = 1 << 4,
    GroupWrite = 1 << 5,
    GroupExecute = 1 << 6,
    EveryoneRead = 1 << 7,
    EveryoneWrite = 1 << 8,
    EveryoneExecute = 1 << 9
}