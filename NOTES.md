## Tables
* The `tbl` fles are created from `XML` files.

## Hash Generation
This pseudocode for hash generation was provided by moggabor.
The hash algorithm used was `32-bit FNV-1a`.

```
descriptorsHash = 0x811c9dc5
layoutHash = 0x811c9dc5
explicitPaddingSize = 0
maxColumnAlignment = 1
lineSize = 0

for column in columns:
	descriptorsHash = crc32(column.name, descriptorsHash)
	descriptorsHash = crc32(column.typeID, descriptorsHash)
	layoutHash = crc32(column.offset, layoutHash)

	if columnDataType == Padding:
		explicitPaddingSize += column.size
		continue

	nextOffset = column.offset + column.size
	if lineSize < nextOffset:
		lineSize = nextOffset

	if maxColumnAlignment < column.alignment:
		maxColumnAlignment = column.alignment

lineSize += explicitPaddingSize

if lineSize % maxColumnAlignment:
	lineSize = maxColumnAlignment * ((lineSize + maxColumnAlignment - 1) / maxColumnAlignment)

layoutHash = crc32(lineSize, layoutHash)
```

#### Notes
* Is `column.typeID` the string in the xml header (e.g., character varying) or is it an integer value?
