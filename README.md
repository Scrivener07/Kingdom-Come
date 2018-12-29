# Kingdom Come Deliverance
This project adds tools and utilities for content creation in Kingdom Come Deliverance, a game by Warhorse Studios.

### Dependencies
This solution depends on a private project not included in the source here.
Its a small library with some code I reuse from time to time.
This will change once I break off the pieces I need.

# [Table File Format](https://wiki.nexusmods.com/index.php/TBL_File_Format_in_KCD)

## Top-Level File Format
| Offset                        | Name        | Type                                                                         |
|-------------------------------|-------------|------------------------------------------------------------------------------|
| `0`                           | Header      | Header                                                                       |
| `28`                          | Rows        | Type depends on the table structure, count is  `Line Count` within `Header`. |
| `28 + line size * line count` | String Data |                                                                              |

## Header Format
| Offset | Name                | Type                |
|--------|---------------------|---------------------|
| 0      | File Format Version | 32-bit signed int   |
| 4      | Descriptors Hash    | 32-bit unsigned int |
| 8      | Layout Hash         | 32-bit unsigned int |
| 12     | Table Version       | 32-bit signed int   |
| 16     | Line Count          | 32-bit signed int   |
| 20     | String Data Size    | 32-bit signed int   |
| 24     | Unique String Count | 32-bit signed int   |

### Notes ###
* Line size can be calculated as `(file size - header size - string data size) / line count`.
* For more info about table data types, see Table Data Types.

# [Table Data Types](https://wiki.nexusmods.com/index.php/Table_Data_Types_in_KCD)
| Name    | Width in TBL file          | Name in XML table descriptor |
|---------|----------------------------|------------------------------|
| Int     | 32 bit                     | integer                      |
| Int64   | 64 bit                     | bigint                       |
| Float   | 32 bit                     | real                         |
| Guid    | 128 bit                    | uuid                         |
| Bool    | 8 bit                      | boolean                      |
| String  | 32 bit                     | text, character varying      |
| Vec3    | 96 bit (3 * 32 bit)        | vec3                         |
| Quat    | 128 bit (4 * 32 bit)       | quat                         |
| QuatT   | 224 bit ((4 + 3) * 32 bit) | quatt                        |
| Padding | variable                   |                              |

### Notes ###
* Strings are stored as 32-bit signed integers pointing into the string table.
* Most tables do not use any padding. Whether table uses or doesn't use padding is hard-coded in KCD source. KCD data can only tell you that there is some padding somewhere, but not where. To see whether table uses padding, compare table description in XML file with line size in TBL file.

### Example Type - `...\Data\Libs\Tables\rpg\poi_type.tbl` ###
| Column                   | Type   | Width   |
|--------------------------|--------|---------|
| poi_type_id              | Guid   | 128 bit |
| mark_type                | Int    | 32 bit  |
| label                    | String | &nbsp;  |
| discovery_msg            | String | &nbsp;  |
| discovery_dist           | Float  | 32 bit  |
| compass_mark_type_id     | Int    | 32 bit  |
| associated_codex_perk_id | Guid   | 128 bit |
| discovery_msg_mode       | Int    | 32 bit  |
| discoverable_by_location | Bool   | 8 bit   |
| ui_order                 | Int    | 32 bit  |
