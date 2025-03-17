# C1 D2 06 - CashShopStorage (by server)

## Is sent when

Get cash shop storage info.

## Causes the following actions on the client side

Got cash shop storage info.

## Structure

| Index | Length | Data Type | Value | Description |
|-------|--------|-----------|-------|-------------|
| 0 | 1 |   Byte   | 0xC1  | [Packet type](PacketTypes.md) |
| 1 | 1 |    Byte   |   12   | Packet header - length of the packet |
| 2 | 1 |    Byte   | 0xD2  | Packet header - packet type identifier |
| 3 | 1 |    Byte   | 0x06  | Packet header - sub packet type identifier |
| 4 | 2 | ShortLittleEndian |  | TotalItemCount |
| 6 | 2 | ShortLittleEndian |  | CurrentItemCount |
| 8 | 2 | ShortLittleEndian |  | PageIndex |
| 10 | 2 | ShortLittleEndian |  | TotalPage |