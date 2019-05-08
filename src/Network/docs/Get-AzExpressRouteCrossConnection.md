---
external help file: Az.Network-help.xml
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/get-azexpressroutecrossconnection
schema: 2.0.0
---

# Get-AzExpressRouteCrossConnection

## SYNOPSIS
Gets details about the specified ExpressRouteCrossConnection.

## SYNTAX

### ListSubscriptionIdViaHost (Default)
```
Get-AzExpressRouteCrossConnection [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetSubscriptionIdViaHost
```
Get-AzExpressRouteCrossConnection -CrossConnectionName <String> -ResourceGroupName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzExpressRouteCrossConnection -CrossConnectionName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListSubscriptionIdViaHost1
```
Get-AzExpressRouteCrossConnection -ResourceGroupName <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List1
```
Get-AzExpressRouteCrossConnection -ResourceGroupName <String> -SubscriptionId <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List
```
Get-AzExpressRouteCrossConnection -SubscriptionId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets details about the specified ExpressRouteCrossConnection.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -CrossConnectionName
The name of the ExpressRouteCrossConnection (service key of the circuit).

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -ResourceGroupName
The name of the resource group (peering location of the circuit).

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get, ListSubscriptionIdViaHost1, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Get, List1, List
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

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IExpressRouteCrossConnection
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.network/get-azexpressroutecrossconnection](https://docs.microsoft.com/en-us/powershell/module/az.network/get-azexpressroutecrossconnection)
