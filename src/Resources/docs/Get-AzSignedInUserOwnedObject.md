---
external help file: Az.Resources-help.xml
Module Name: Az.Resources
online version: https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azsignedinuserownedobject
schema: 2.0.0
---

# Get-AzSignedInUserOwnedObject

## SYNOPSIS
Get the list of directory objects that are owned by the user.

## SYNTAX

```
Get-AzSignedInUserOwnedObject -TenantId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get the list of directory objects that are owned by the user.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
The tenant ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Resources.Models.Api16.IDirectoryObject
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azsignedinuserownedobject](https://docs.microsoft.com/en-us/powershell/module/az.resources/get-azsignedinuserownedobject)
