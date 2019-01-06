meta:
  id: table
  title: Table Data
  application: 'Kingdom Come: Deliverance'
  file-extension: tbl
  license: MIT
  ks-version: 0.7.0
  encoding: utf-8
  endian: le
doc: Tabular data which represents rows and columns.
doc-ref: https://wiki.fireundubh.com/kingdomcome
seq:
  - id: header
    type: header_type
  - id: row_dlc
    type: dlc
    repeat: expr
    repeat-expr: header.line_count
    if: header.descriptors == 0xDB96E796
  - id: row_game_over
    type: game_over
    repeat: expr
    repeat-expr: header.line_count
    if: header.descriptors == 0x6D2A1A4F
  - id: strings
    type: key_value_pair
    repeat: expr
    repeat-expr: header.line_count
    if: header.unique_strings_count > 0
types:
  table_alignment:
    seq:
      - id: padding
        size: (4 - _io.pos) % 4
  header_type:
    seq:
      - id: version
        type: s4le
      - id: descriptors
        type: u4le
      - id: layout
        type: u4le
      - id: table_version
        type: s4le
      - id: line_count
        type: s4le
      - id: string_data_size
        type: s4le
      - id: unique_strings_count
        type: s4le
  dlc:
    seq:
      - id: dlc_id
        type: s4le
      - id: affects_savegame
        type: s2le
      - id: need_mount
        type: s2le
  game_over:
    seq:
      - id: id
        type: s8le
      - id: name
        type: s8le
      - id: text
        type: s8le
      - id: type
        type: s8le
  key_value_pair:
    seq:
      - id: key
        type: strz
      - id: value
        type: strz
