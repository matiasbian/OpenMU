# C1 D2 05 - CashShopStorage (by client)

## Is sent when

Get cash shop storage info.

## Causes the following actions on the server side

Got cash shop storage info.

## Structure

| Index | Length | Data Type | Value | Description |
|-------|--------|-----------|-------|-------------|
| 0 | 1 |   Byte   | 0xC1  | [Packet type](PacketTypes.md) |
| 1 | 1 |    Byte   |   10   | Packet header - length of the packet |
| 2 | 1 |    Byte   | 0xD2  | Packet header - packet type identifier |
| 3 | 1 |    Byte   | 0x05  | Packet header - sub packet type identifier |
| 4 | 4 | IntegerLittleEndian |  | Page |
| 8 | 1 | CashShopStorageType |  | StorageType |
| 9 | 1 | Byte |  | Unk |

### CashShopStorageType Enum

Describes the type of cash shop storage.

| Value | Name | Description |
|-------|------|-------------|
| 83 | SafeKeeping | Safe keeping type. |
| 71 | PresentBox | Present box type. |
| 90 | Total | Total type. |