// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class WeaponClass : KaitaiStruct
    {
        public static WeaponClass FromFile(string fileName)
        {
            return new WeaponClass(new KaitaiStream(fileName));
        }

        public WeaponClass(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _table = new Header(m_io, this, m_root);
            _rows = new List<Row>((int) (Table.RowCount));
            for (var i = 0; i < Table.RowCount; i++)
            {
                _rows.Add(new Row(m_io, this, m_root));
            }
            _strings = new List<string>((int) (Table.UniqueStringsCount));
            for (var i = 0; i < Table.UniqueStringsCount; i++)
            {
                _strings.Add(System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true)));
            }
        }
        public partial class Uuid : KaitaiStruct
        {
            public static Uuid FromFile(string fileName)
            {
                return new Uuid(new KaitaiStream(fileName));
            }

            public Uuid(KaitaiStream p__io, WeaponClass.Row p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _uuidType = m_io.ReadBytes(16);
            }
            private byte[] _uuidType;
            private WeaponClass m_root;
            private WeaponClass.Row m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public WeaponClass M_Root { get { return m_root; } }
            public WeaponClass.Row M_Parent { get { return m_parent; } }
        }
        public partial class Trifloat : KaitaiStruct
        {
            public static Trifloat FromFile(string fileName)
            {
                return new Trifloat(new KaitaiStream(fileName));
            }

            public Trifloat(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _floatA = m_io.ReadF4le();
                _floatB = m_io.ReadF4le();
                _floatC = m_io.ReadF4le();
            }
            private float _floatA;
            private float _floatB;
            private float _floatC;
            private WeaponClass m_root;
            private KaitaiStruct m_parent;
            public float FloatA { get { return _floatA; } }
            public float FloatB { get { return _floatB; } }
            public float FloatC { get { return _floatC; } }
            public WeaponClass M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, WeaponClass p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _weaponClassId = m_io.ReadS4le();
                _weaponClassName = m_io.ReadS4le();
                _skillId = m_io.ReadS4le();
                _attachmentSlotId = m_io.ReadS4le();
                _weaponEquipSlotId = m_io.ReadS4le();
                _inRightHand = m_io.ReadS1();
                _holsterSlotId = m_io.ReadS4le();
                _primaryAttackTypeId = m_io.ReadS4le();
                _secondaryAttackTypeId = m_io.ReadS4le();
                _attackDistance = m_io.ReadF4le();
                _isBlocking = m_io.ReadS1();
                _syncGuardDistance = m_io.ReadF4le();
                _syncGuardPriority = m_io.ReadS4le();
                _itemManipulationType = m_io.ReadS4le();
                _maxAttackDistance = m_io.ReadF4le();
                _collisionMode = m_io.ReadS4le();
                _animCollisionMode = m_io.ReadS4le();
                _combatPriority = m_io.ReadS4le();
                _isTwohanded = m_io.ReadS1();
                _horsePullDownDistance = m_io.ReadF4le();
                _horsePullDownMaxSpeed = m_io.ReadF4le();
                _horsePullDownZTolerance = m_io.ReadF4le();
                _huntAttackDistance = m_io.ReadF4le();
                _zoneChangeTimeoutCoef = m_io.ReadF4le();
                _drawBuffId = new Uuid(m_io, this, m_root);
                _alternativeDrawBuffId = new Uuid(m_io, this, m_root);
                _sharpeningZoneCount = m_io.ReadS4le();
            }
            private int _weaponClassId;
            private int _weaponClassName;
            private int _skillId;
            private int _attachmentSlotId;
            private int _weaponEquipSlotId;
            private sbyte _inRightHand;
            private int _holsterSlotId;
            private int _primaryAttackTypeId;
            private int _secondaryAttackTypeId;
            private float _attackDistance;
            private sbyte _isBlocking;
            private float _syncGuardDistance;
            private int _syncGuardPriority;
            private int _itemManipulationType;
            private float _maxAttackDistance;
            private int _collisionMode;
            private int _animCollisionMode;
            private int _combatPriority;
            private sbyte _isTwohanded;
            private float _horsePullDownDistance;
            private float _horsePullDownMaxSpeed;
            private float _horsePullDownZTolerance;
            private float _huntAttackDistance;
            private float _zoneChangeTimeoutCoef;
            private Uuid _drawBuffId;
            private Uuid _alternativeDrawBuffId;
            private int _sharpeningZoneCount;
            private WeaponClass m_root;
            private WeaponClass m_parent;
            public int WeaponClassId { get { return _weaponClassId; } }
            public int WeaponClassName { get { return _weaponClassName; } }
            public int SkillId { get { return _skillId; } }
            public int AttachmentSlotId { get { return _attachmentSlotId; } }
            public int WeaponEquipSlotId { get { return _weaponEquipSlotId; } }
            public sbyte InRightHand { get { return _inRightHand; } }
            public int HolsterSlotId { get { return _holsterSlotId; } }
            public int PrimaryAttackTypeId { get { return _primaryAttackTypeId; } }
            public int SecondaryAttackTypeId { get { return _secondaryAttackTypeId; } }
            public float AttackDistance { get { return _attackDistance; } }
            public sbyte IsBlocking { get { return _isBlocking; } }
            public float SyncGuardDistance { get { return _syncGuardDistance; } }
            public int SyncGuardPriority { get { return _syncGuardPriority; } }
            public int ItemManipulationType { get { return _itemManipulationType; } }
            public float MaxAttackDistance { get { return _maxAttackDistance; } }
            public int CollisionMode { get { return _collisionMode; } }
            public int AnimCollisionMode { get { return _animCollisionMode; } }
            public int CombatPriority { get { return _combatPriority; } }
            public sbyte IsTwohanded { get { return _isTwohanded; } }
            public float HorsePullDownDistance { get { return _horsePullDownDistance; } }
            public float HorsePullDownMaxSpeed { get { return _horsePullDownMaxSpeed; } }
            public float HorsePullDownZTolerance { get { return _horsePullDownZTolerance; } }
            public float HuntAttackDistance { get { return _huntAttackDistance; } }
            public float ZoneChangeTimeoutCoef { get { return _zoneChangeTimeoutCoef; } }
            public Uuid DrawBuffId { get { return _drawBuffId; } }
            public Uuid AlternativeDrawBuffId { get { return _alternativeDrawBuffId; } }
            public int SharpeningZoneCount { get { return _sharpeningZoneCount; } }
            public WeaponClass M_Root { get { return m_root; } }
            public WeaponClass M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _quatX = m_io.ReadS4le();
                _quatY = m_io.ReadS4le();
                _quatZ = m_io.ReadS4le();
                _quatW = m_io.ReadS4le();
            }
            private int _quatX;
            private int _quatY;
            private int _quatZ;
            private int _quatW;
            private WeaponClass m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public WeaponClass M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _quattType = m_io.ReadBytes(28);
            }
            private byte[] _quattType;
            private WeaponClass m_root;
            private KaitaiStruct m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public WeaponClass M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, WeaponClass p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _version = m_io.ReadS4le();
                _descriptorsHash = m_io.ReadU4le();
                _layoutHash = m_io.ReadU4le();
                _tableVersion = m_io.ReadS4le();
                _rowCount = m_io.ReadS4le();
                _stringDataSize = m_io.ReadS4le();
                _uniqueStringsCount = m_io.ReadS4le();
            }
            private int _version;
            private uint _descriptorsHash;
            private uint _layoutHash;
            private int _tableVersion;
            private int _rowCount;
            private int _stringDataSize;
            private int _uniqueStringsCount;
            private WeaponClass m_root;
            private WeaponClass m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public WeaponClass M_Root { get { return m_root; } }
            public WeaponClass M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _vec3X = m_io.ReadS4le();
                _vec3Y = m_io.ReadS4le();
                _vec3Z = m_io.ReadS4le();
            }
            private int _vec3X;
            private int _vec3Y;
            private int _vec3Z;
            private WeaponClass m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public WeaponClass M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, WeaponClass p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _paddingType = m_io.ReadBytes(16);
            }
            private byte[] _paddingType;
            private WeaponClass m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public WeaponClass M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private WeaponClass m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public WeaponClass M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
