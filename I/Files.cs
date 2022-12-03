using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Files
{
    Dictionary<string, Permissions> files = new Dictionary<string, Permissions>();
    public void CreateFile(string filename)
    {
        files.Add(filename, Permissions.Default);
    }
    
    public void AddPermission(string filename, string permissionName)
    {
        var x = PermissionBuilder.FromName(permissionName);
        files[filename] |= x;
    }
    
    public void RemovePermission(string filename, string permissionName)
    {
        var x = PermissionBuilder.FromName(permissionName);
        files[filename] &= ~ x;
    }
    public override string ToString()
    {
        var s = new StringBuilder();
        foreach (var item in files)
        {
            s.Append($"{item.Key}: {item.Value}\n"); 
        }
        
        return string.Join("", s.ToString().Split(","));
    }
}