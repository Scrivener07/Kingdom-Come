meta:
  id: table
  file-extension: tbl
  encoding: utf-8
  endian: le
seq:
  - id: tbl_header
    type: header
  - id: lines
    type: line
    repeat: expr
    repeat-expr: tbl_header.line_count
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
  line:
    seq:
      - id: id
        type: s8le
      - id: name
        type: s8le
      - id: text
        type: s8le
      - id: type
        type: s8le
