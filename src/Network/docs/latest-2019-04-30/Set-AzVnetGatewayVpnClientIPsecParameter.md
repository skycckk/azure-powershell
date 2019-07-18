---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/set-azvnetgatewayvpnclientipsecparameter
schema: 2.0.0
---

# Set-AzVnetGatewayVpnClientIPsecParameter

## SYNOPSIS
The Set VpnclientIpsecParameters operation sets the vpnclient ipsec policy for P2S client of virtual network gateway in the specified resource group through Network resource provider.

## SYNTAX

### Set (Default)
```
Set-AzVnetGatewayVpnClientIPsecParameter -ResourceGroupName <String> -SubscriptionId <String>
 -VnetGatewayName <String> [-VpnclientIPsecParam <IVpnClientIPsecParameters>] [-DefaultProfile <PSObject>]
 [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetExpanded
```
Set-AzVnetGatewayVpnClientIPsecParameter -ResourceGroupName <String> -SubscriptionId <String>
 -VnetGatewayName <String> -DhGroup <DhGroup> -IPsecEncryption <IpsecEncryption>
 -IPsecIntegrity <IpsecIntegrity> -IkeEncryption <IkeEncryption> -IkeIntegrity <IkeIntegrity>
 -PfsGroup <PfsGroup> -SaDataSizeKilobyte <Int32> -SaLifeTimeSecond <Int32> [-DefaultProfile <PSObject>]
 [-AsJob] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The Set VpnclientIpsecParameters operation sets the vpnclient ipsec policy for P2S client of virtual network gateway in the specified resource group through Network resource provider.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -DhGroup
The DH Group used in IKE Phase 1 for initial SA.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.DhGroup
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IkeEncryption
The IKE encryption algorithm (IKE phase 2).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IkeEncryption
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IkeIntegrity
The IKE integrity algorithm (IKE phase 2).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IkeIntegrity
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IPsecEncryption
The IPSec encryption algorithm (IKE phase 1).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IpsecEncryption
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IPsecIntegrity
The IPSec integrity algorithm (IKE phase 1).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.IpsecIntegrity
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PfsGroup
The Pfs Group used in IKE Phase 2 for new child SA.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.PfsGroup
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SaDataSizeKilobyte
The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for P2S client..

```yaml
Type: System.Int32
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SaLifeTimeSecond
The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for P2S client.

```yaml
Type: System.Int32
Parameter Sets: SetExpanded
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VnetGatewayName
The name of the virtual network gateway.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: VirtualNetworkGatewayName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VpnclientIPsecParam
An IPSec parameters for a virtual network gateway P2S connection.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVpnClientIPsecParameters
Parameter Sets: Set
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVpnClientIPsecParameters

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVpnClientIPsecParameters

## ALIASES

### Set-AzVpnClientIpsecParameter

### Set-AzVirtualNetworkGatewayVpnClientIPsecParameter

## RELATED LINKS
