// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{
    public partial class CombatActionPerfectBlock : KaitaiStruct
    {
        public static CombatActionPerfectBlock FromFile(string fileName)
        {
            return new CombatActionPerfectBlock(new KaitaiStream(fileName));
        }

        public CombatActionPerfectBlock(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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

            public Uuid(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private KaitaiStruct m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Trifloat : KaitaiStruct
        {
            public static Trifloat FromFile(string fileName)
            {
                return new Trifloat(new KaitaiStream(fileName));
            }

            public Trifloat(KaitaiStream p__io, CombatActionPerfectBlock.Row p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private CombatActionPerfectBlock.Row m_parent;
            public float FloatA { get { return _floatA; } }
            public float FloatB { get { return _floatB; } }
            public float FloatC { get { return _floatC; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public CombatActionPerfectBlock.Row M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatActionPerfectBlock p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _actorClassHash = m_io.ReadS4le();
                _oppActorClassHash = m_io.ReadS4le();
                _mounted = m_io.ReadS1();
                _oppMounted = m_io.ReadS1();
                _timestamp = m_io.ReadS8le();
                _animationDuration = m_io.ReadF4le();
                _fadeIn = m_io.ReadF4le();
                _initAlign0 = new Quatt(m_io, this, m_root);
                _initAlign1 = new Quatt(m_io, this, m_root);
                _initSecAlign0 = new Quatt(m_io, this, m_root);
                _initSecAlign1 = new Quatt(m_io, this, m_root);
                _blockTimeToStart = m_io.ReadF4le();
                _blockTimeToHit = m_io.ReadF4le();
                _blockTimeToEnd = m_io.ReadF4le();
                _blockingHand = m_io.ReadS4le();
                _attackTimeToSpbStart = m_io.ReadF4le();
                _attackTimeToStart = m_io.ReadF4le();
                _attackTimeToHit = m_io.ReadF4le();
                _attackTimeToWithdraw = m_io.ReadF4le();
                _attackTimeToEnd = m_io.ReadF4le();
                _perfectBlockWindow = m_io.ReadF4le();
                _syncPerfectBlockWindow = m_io.ReadF4le();
                _dodgeWindow = m_io.ReadF4le();
                _hitDistance = m_io.ReadF4le();
                _attackingHand = m_io.ReadS4le();
                _blockZoneId = m_io.ReadS4le();
                _oppAttackTypeId = m_io.ReadS4le();
                _inputClassId = m_io.ReadS4le();
                _attackTypeId = m_io.ReadS4le();
                _attackZoneId = m_io.ReadS4le();
                _riposteZoneId = m_io.ReadS4le();
                _rWeaponClassId = m_io.ReadS4le();
                _lWeaponClassId = m_io.ReadS4le();
                _rWeaponGroupId = m_io.ReadS4le();
                _lWeaponGroupId = m_io.ReadS4le();
                _oppRWeaponClassId = m_io.ReadS4le();
                _oppLWeaponClassId = m_io.ReadS4le();
                _oppRWeaponGroupId = m_io.ReadS4le();
                _oppLWeaponGroupId = m_io.ReadS4le();
                _guardTypeId = m_io.ReadS4le();
                _guardStanceId = m_io.ReadS4le();
                _oppGuardStanceId = m_io.ReadS4le();
                _guardZoneId = m_io.ReadS4le();
                _actionTypeId = m_io.ReadS4le();
                _endGuardTypeId = m_io.ReadS4le();
                _endGuardZoneId = m_io.ReadS4le();
                _endGuardStanceId = m_io.ReadS4le();
                _blkMnFragmentId = m_io.ReadS4le();
                _blkMnOptionIndex = m_io.ReadS4le();
                _blkMnTags = m_io.ReadS4le();
                _syncHitStartByPc = m_io.ReadS1();
                _zSpatialGrid = m_io.ReadS4le();
                _hasHitAnimevents = m_io.ReadS1();
                _endPoint = new Trifloat(m_io, this, m_root);
                _syncPoint = m_io.ReadF4le();
            }
            private int _actorClassHash;
            private int _oppActorClassHash;
            private sbyte _mounted;
            private sbyte _oppMounted;
            private long _timestamp;
            private float _animationDuration;
            private float _fadeIn;
            private Quatt _initAlign0;
            private Quatt _initAlign1;
            private Quatt _initSecAlign0;
            private Quatt _initSecAlign1;
            private float _blockTimeToStart;
            private float _blockTimeToHit;
            private float _blockTimeToEnd;
            private int _blockingHand;
            private float _attackTimeToSpbStart;
            private float _attackTimeToStart;
            private float _attackTimeToHit;
            private float _attackTimeToWithdraw;
            private float _attackTimeToEnd;
            private float _perfectBlockWindow;
            private float _syncPerfectBlockWindow;
            private float _dodgeWindow;
            private float _hitDistance;
            private int _attackingHand;
            private int _blockZoneId;
            private int _oppAttackTypeId;
            private int _inputClassId;
            private int _attackTypeId;
            private int _attackZoneId;
            private int _riposteZoneId;
            private int _rWeaponClassId;
            private int _lWeaponClassId;
            private int _rWeaponGroupId;
            private int _lWeaponGroupId;
            private int _oppRWeaponClassId;
            private int _oppLWeaponClassId;
            private int _oppRWeaponGroupId;
            private int _oppLWeaponGroupId;
            private int _guardTypeId;
            private int _guardStanceId;
            private int _oppGuardStanceId;
            private int _guardZoneId;
            private int _actionTypeId;
            private int _endGuardTypeId;
            private int _endGuardZoneId;
            private int _endGuardStanceId;
            private int _blkMnFragmentId;
            private int _blkMnOptionIndex;
            private int _blkMnTags;
            private sbyte _syncHitStartByPc;
            private int _zSpatialGrid;
            private sbyte _hasHitAnimevents;
            private Trifloat _endPoint;
            private float _syncPoint;
            private CombatActionPerfectBlock m_root;
            private CombatActionPerfectBlock m_parent;
            public int ActorClassHash { get { return _actorClassHash; } }
            public int OppActorClassHash { get { return _oppActorClassHash; } }
            public sbyte Mounted { get { return _mounted; } }
            public sbyte OppMounted { get { return _oppMounted; } }
            public long Timestamp { get { return _timestamp; } }
            public float AnimationDuration { get { return _animationDuration; } }
            public float FadeIn { get { return _fadeIn; } }
            public Quatt InitAlign0 { get { return _initAlign0; } }
            public Quatt InitAlign1 { get { return _initAlign1; } }
            public Quatt InitSecAlign0 { get { return _initSecAlign0; } }
            public Quatt InitSecAlign1 { get { return _initSecAlign1; } }
            public float BlockTimeToStart { get { return _blockTimeToStart; } }
            public float BlockTimeToHit { get { return _blockTimeToHit; } }
            public float BlockTimeToEnd { get { return _blockTimeToEnd; } }
            public int BlockingHand { get { return _blockingHand; } }
            public float AttackTimeToSpbStart { get { return _attackTimeToSpbStart; } }
            public float AttackTimeToStart { get { return _attackTimeToStart; } }
            public float AttackTimeToHit { get { return _attackTimeToHit; } }
            public float AttackTimeToWithdraw { get { return _attackTimeToWithdraw; } }
            public float AttackTimeToEnd { get { return _attackTimeToEnd; } }
            public float PerfectBlockWindow { get { return _perfectBlockWindow; } }
            public float SyncPerfectBlockWindow { get { return _syncPerfectBlockWindow; } }
            public float DodgeWindow { get { return _dodgeWindow; } }
            public float HitDistance { get { return _hitDistance; } }
            public int AttackingHand { get { return _attackingHand; } }
            public int BlockZoneId { get { return _blockZoneId; } }
            public int OppAttackTypeId { get { return _oppAttackTypeId; } }
            public int InputClassId { get { return _inputClassId; } }
            public int AttackTypeId { get { return _attackTypeId; } }
            public int AttackZoneId { get { return _attackZoneId; } }
            public int RiposteZoneId { get { return _riposteZoneId; } }
            public int RWeaponClassId { get { return _rWeaponClassId; } }
            public int LWeaponClassId { get { return _lWeaponClassId; } }
            public int RWeaponGroupId { get { return _rWeaponGroupId; } }
            public int LWeaponGroupId { get { return _lWeaponGroupId; } }
            public int OppRWeaponClassId { get { return _oppRWeaponClassId; } }
            public int OppLWeaponClassId { get { return _oppLWeaponClassId; } }
            public int OppRWeaponGroupId { get { return _oppRWeaponGroupId; } }
            public int OppLWeaponGroupId { get { return _oppLWeaponGroupId; } }
            public int GuardTypeId { get { return _guardTypeId; } }
            public int GuardStanceId { get { return _guardStanceId; } }
            public int OppGuardStanceId { get { return _oppGuardStanceId; } }
            public int GuardZoneId { get { return _guardZoneId; } }
            public int ActionTypeId { get { return _actionTypeId; } }
            public int EndGuardTypeId { get { return _endGuardTypeId; } }
            public int EndGuardZoneId { get { return _endGuardZoneId; } }
            public int EndGuardStanceId { get { return _endGuardStanceId; } }
            public int BlkMnFragmentId { get { return _blkMnFragmentId; } }
            public int BlkMnOptionIndex { get { return _blkMnOptionIndex; } }
            public int BlkMnTags { get { return _blkMnTags; } }
            public sbyte SyncHitStartByPc { get { return _syncHitStartByPc; } }
            public int ZSpatialGrid { get { return _zSpatialGrid; } }
            public sbyte HasHitAnimevents { get { return _hasHitAnimevents; } }
            public Trifloat EndPoint { get { return _endPoint; } }
            public float SyncPoint { get { return _syncPoint; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public CombatActionPerfectBlock M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, CombatActionPerfectBlock.Row p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private CombatActionPerfectBlock.Row m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public CombatActionPerfectBlock.Row M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, CombatActionPerfectBlock p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private CombatActionPerfectBlock m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public CombatActionPerfectBlock M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatActionPerfectBlock p__root = null) : base(p__io)
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
            private CombatActionPerfectBlock m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public CombatActionPerfectBlock M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatActionPerfectBlock m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatActionPerfectBlock M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
