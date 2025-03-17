# C1 D2 00 - CashShopInit (by server)

## Is sent when

Init cash shop.

## Causes the following actions on the client side

Cash shop is inited.

## Structure

| Index | Length | Data Type | Value | Description |
|-------|--------|-----------|-------|-------------|
| 0 | 1 |   Byte   | 0xC1  | [Packet type](PacketTypes.md) |
| 1 | 1 |    Byte   |   4   | Packet header - length of the packet |
| 2 | 1 |    Byte   | 0xD2  | Packet header - packet type identifier |
| 3 | 1 |    Byte   | 0x00  | Packet header - sub packet type identifier |