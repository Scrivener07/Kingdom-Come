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
  - id: tbl_header
    type: header
  - id: lines_game_over
    type: line_game_over
    repeat: expr
    repeat-expr: tbl_header.line_count
    if: tbl_header.descriptors == 0x6D2A1A4F
  - id: lines_dlc
    type: line_dlc
    repeat: expr
    repeat-expr: tbl_header.line_count
    if: tbl_header.descriptors == 0xDB96E796
  - id: strings
    type: str
    terminator: 0
    repeat: expr
    repeat-expr: tbl_header.unique_strings_count
types:
  alignment_type:
    seq:
      - id: alignment_id
        size: (4 - _io.pos) % 4
  header:
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
  line_game_over:
    seq:
      - id: id
        type: s8le
      - id: name
        type: s8le
      - id: text
        type: s8le
      - id: type
        type: s8le
  line_dlc:
    seq:
      - id: affects_savegame
        type: s1
      - id: dlc_id
        type: s4le
      - id: need_mount
        type: s1
