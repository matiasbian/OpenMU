# C1 D2 0D - CashShopItem (by server)

## Is sent when

Get cash shop storage items.

## Causes the following actions on the client side

Got cash shop storage items.

## Structure

| Index | Length | Data Type | Value | Description |
|-------|--------|-----------|-------|-------------|
| 0 | 1 |   Byte   | 0xC1  | [Packet type](PacketTypes.md) |
| 1 | 1 |    Byte   |   33   | Packet header - length of the packet |
| 2 | 1 |    Byte   | 0xD2  | Packet header - packet type identifier |
| 3 | 1 |    Byte   | 0x0D  | Packet header - sub packet type identifier |
| 4 | 4 | IntegerLittleEndian |  | StorageIndex |
| 8 | 4 | IntegerLittleEndian |  | ItemSeq |
| 12 | 4 | IntegerLittleEndian |  | StorageGroupCode |
| 16 | 4 | IntegerLittleEndian |  | ProductSeq |
| 20 | 4 | IntegerLittleEndian |  | PriceSeq |
| 24 | 8 | Double |  | CashPoint |
| 32 | 1 | Byte |  | ItemType |