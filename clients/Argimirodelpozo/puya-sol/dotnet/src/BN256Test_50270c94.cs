using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.Argimirodelpozo.puya_sol.BN256Test_50270c94
{


    public class BN256TestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BN256TestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EcAddReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Rx { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Ry { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRx = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vRx.From(Rx);
                    ret.AddRange(vRx.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vRy.From(Ry);
                    ret.AddRange(vRy.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EcAddReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EcAddReturn();
                    uint count = 0;
                    var vRx = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vRx.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Rx = vRx;
                    var vRy = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vRy.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Ry = vRy;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EcAddReturn);
                }
                public bool Equals(EcAddReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EcAddReturn left, EcAddReturn right)
                {
                    return EqualityComparer<EcAddReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EcAddReturn left, EcAddReturn right)
                {
                    return !(left == right);
                }

            }

            public class EcMulReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Rx { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Ry { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRx = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vRx.From(Rx);
                    ret.AddRange(vRx.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vRy.From(Ry);
                    ret.AddRange(vRy.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EcMulReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EcMulReturn();
                    uint count = 0;
                    var vRx = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vRx.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Rx = vRx;
                    var vRy = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vRy.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Ry = vRy;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EcMulReturn);
                }
                public bool Equals(EcMulReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EcMulReturn left, EcMulReturn right)
                {
                    return EqualityComparer<EcMulReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EcMulReturn left, EcMulReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Elliptic curve point addition on BN256 (alt_bn128).
        /// Maps to EVM precompile at address 6.
        ///</summary>
        /// <param name="x1"> </param>
        /// <param name="y1"> </param>
        /// <param name="x2"> </param>
        /// <param name="y2"> </param>
        public async Task<Structs.EcAddReturn> EcAdd(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 54, 189, 212 };

            var result = await base.SimApp(new List<object> { abiHandle, x1, y1, x2, y2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EcAddReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EcAdd_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 54, 189, 212 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x1, y1, x2, y2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Elliptic curve scalar multiplication on BN256.
        /// Maps to EVM precompile at address 7.
        ///</summary>
        /// <param name="x"> </param>
        /// <param name="y"> </param>
        /// <param name="s"> </param>
        public async Task<Structs.EcMulReturn> EcMul(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 46, 107, 48 };

            var result = await base.SimApp(new List<object> { abiHandle, x, y, s }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EcMulReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EcMul_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 46, 107, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x, y, s }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///BN256 pairing check. Returns true if the pairing equation holds.
        /// Maps to EVM precompile at address 8.
        /// Takes 2 pairs: (G1_1, G2_1, G1_2, G2_2)
        /// G1 points are 2 uint256, G2 points are 4 uint256.
        /// So 2 pairs = 2 * (2 + 4) = 12 uint256 values.
        ///</summary>
        /// <param name="ax1"> </param>
        /// <param name="ay1"> </param>
        /// <param name="bx1_1"> </param>
        /// <param name="bx1_2"> </param>
        /// <param name="by1_1"> </param>
        /// <param name="by1_2"> </param>
        /// <param name="ax2"> </param>
        /// <param name="ay2"> </param>
        /// <param name="bx2_1"> </param>
        /// <param name="bx2_2"> </param>
        /// <param name="by2_1"> </param>
        /// <param name="by2_2"> </param>
        public async Task<bool> PairingCheck2(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ax1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ay1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx1_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx1_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by1_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by1_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ax2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ay2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx2_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx2_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by2_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by2_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 174, 175, 250 };

            var result = await base.SimApp(new List<object> { abiHandle, ax1, ay1, bx1_1, bx1_2, by1_1, by1_2, ax2, ay2, bx2_1, bx2_2, by2_1, by2_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PairingCheck2_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ax1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ay1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx1_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx1_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by1_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by1_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ax2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ay2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx2_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 bx2_2, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by2_1, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 by2_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 174, 175, 250 };

            return await base.MakeTransactionList(new List<object> { abiHandle, ax1, ay1, bx1_1, bx1_2, by1_1, by1_2, ax2, ay2, bx2_1, bx2_2, by2_1, by2_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQk4yNTZUZXN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7ImVjQWRkUmV0dXJuIjpbeyJuYW1lIjoicngiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InJ5IiwidHlwZSI6InVpbnQyNTYifV0sImVjTXVsUmV0dXJuIjpbeyJuYW1lIjoicngiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InJ5IiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZWNBZGQiLCJkZXNjIjoiRWxsaXB0aWMgY3VydmUgcG9pbnQgYWRkaXRpb24gb24gQk4yNTYgKGFsdF9ibjEyOCkuXG4gTWFwcyB0byBFVk0gcHJlY29tcGlsZSBhdCBhZGRyZXNzIDYuIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6ImVjQWRkUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY011bCIsImRlc2MiOiJFbGxpcHRpYyBjdXJ2ZSBzY2FsYXIgbXVsdGlwbGljYXRpb24gb24gQk4yNTYuXG4gTWFwcyB0byBFVk0gcHJlY29tcGlsZSBhdCBhZGRyZXNzIDcuIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJlY011bFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFpcmluZ0NoZWNrMiIsImRlc2MiOiJCTjI1NiBwYWlyaW5nIGNoZWNrLiBSZXR1cm5zIHRydWUgaWYgdGhlIHBhaXJpbmcgZXF1YXRpb24gaG9sZHMuXG4gTWFwcyB0byBFVk0gcHJlY29tcGlsZSBhdCBhZGRyZXNzIDguXG4gVGFrZXMgMiBwYWlyczogKEcxXzEsIEcyXzEsIEcxXzIsIEcyXzIpXG4gRzEgcG9pbnRzIGFyZSAyIHVpbnQyNTYsIEcyIHBvaW50cyBhcmUgNCB1aW50MjU2LlxuIFNvIDIgcGFpcnMgPSAyICogKDIgKyA0KSA9IDEyIHVpbnQyNTYgdmFsdWVzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXgxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXkxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYngxXzEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieDFfMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5MV8xIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnkxXzIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheTIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieDJfMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ4Ml8yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnkyXzEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieTJfMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE0LDEyMiwxMzAsMTM4LDI1OCwyNjYsMjc0LDM4MSwzODksMzk3LDQwNSw0MTMsNDIxLDQyOSw0MzcsNDQ1LDQ1Myw0NjEsNDY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEE1WDBKT01qVTJWR1Z6ZEM1emIyd3VRazR5TlRaVVpYTjBMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNU0F5TlRZZ01qZzRDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGd3TVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsT0RNMlltUmtOQ0F3ZURjME1tVTJZak13SURCNE1UWmhaV0ZtWm1FZ0x5OGdiV1YwYUc5a0lDSmxZMEZrWkNoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBJaXdnYldWMGFHOWtJQ0psWTAxMWJDaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlrb2RXbHVkREkxTml4MWFXNTBNalUyS1NJc0lHMWxkR2h2WkNBaWNHRnBjbWx1WjBOb1pXTnJNaWgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pbGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1pXTkJaR1FnWldOTmRXd2djR0ZwY21sdVowTm9aV05yTWdvZ0lDQWdaWEp5Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTmxiR1pmWm1WaGRIVnlaWE12WTI5dWRISmhZM1J6TDAwd09WOUNUakkxTmxSbGMzUXVjMjlzTGtKT01qVTJWR1Z6ZEM1bFkwRmtaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WalFXUmtPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF6TWdvZ0lDQWdaR2xuSURFS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWEJzWVdObE1pQTVOZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElEWTBDaUFnSUNCbFkxOWhaR1FnUWs0eU5UUm5NUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNVEk0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQnlaWEJzWVdObE1pQXhOakFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6Wld4bVgyWmxZWFIxY21WekwyTnZiblJ5WVdOMGN5OU5NRGxmUWs0eU5UWlVaWE4wTG5OdmJDNUNUakkxTmxSbGMzUXVaV05OZFd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGxZMDExYkRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1ZqWDNOallXeGhjbDl0ZFd3Z1FrNHlOVFJuTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnT1RZS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJSEpsY0d4aFkyVXlJREV5T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEE1WDBKT01qVTJWR1Z6ZEM1emIyd3VRazR5TlRaVVpYTjBMbkJoYVhKcGJtZERhR1ZqYXpKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZV2x5YVc1blEyaGxZMnN5T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01USUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdiRzloWkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXhNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTVRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlERXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV5SURrMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWEJzWVdObE1pQXhNamdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVElnTVRZd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVeUlERTVNZ29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF5TWpRS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh5SUM4dklESTFOZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh6SUM4dklESTRPQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR2x1ZENBek1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhCMWMyaHBiblFnTXpVeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURJNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTXpVeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdWalgzQmhhWEpwYm1kZlkyaGxZMnNnUWs0eU5UUm5NUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjSFZ6YUdsdWRDQXpPRFFLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSTlQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzJWc1psOW1aV0YwZFhKbGN5OWpiMjUwY21GamRITXZUVEE1WDBKT01qVTJWR1Z6ZEM1emIyd3VRazR5TlRaVVpYTjBMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUlBR0FBcUFDSmdJRUZSOThkUUVCTVJoQUFBSWpRNEdBSUs4MUFEUUFnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdGeEFOUUF4R1JSRU1SaEVnZ01FNkRhOTFBUjBMbXN3QkJhdXIvbzJHZ0NPQXdBQkFKRUJEQUEyR2dGSkZTSVNSRFlhQWtrVkloSkVOaG9EU1JVaUVrUTJHZ1JKRlNJU1JEUUFJcTlKVHdaUVNSVWlDU0pZVHdKTVhBQkxBVThGVUVrVklna2lXRndnU3dGUEJGQkpGU0lKSWxoY1FFc0JUd05RU1JVaUNTSllYR0JKVndCQVN3RlhRRURnQUVsWEFDQlBBa3hjZ0V4WElDQmNvRWxYZ0NCTEFWZWdJRThDTlFCTVN3S3JURThDcTFBb1RGQ3dJME0yR2dGSkZTSVNSRFlhQWtrVkloSkVOaG9EU1JVaUVrUTBBQ0t2U1U4RlVFa1ZJZ2tpV0U4Q1RGd0FTd0ZQQkZCSkZTSUpJbGhjSUVzQlR3TlFTUlVpQ1NKWVhFQkpWd0JBU3dGWFFDRGhBRWxYQUNCUEFreGNZRXhYSUNCY2dFbFhZQ0JMQVZlQUlFOENOUUJNU3dLclRFOENxMUFvVEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRU5ob0RTUlVpRWtRMkdnUkpGU0lTUkRZYUJVa1ZJaEpFTmhvR1NSVWlFa1EyR2dkSkZTSVNSRFlhQ0VrVkloSkVOaG9KU1JVaUVrUTJHZ3BKRlNJU1JEWWFDMGtWSWhKRU5ob01TUlVpRWtRMEFDS3ZTVThPVUVrVklna2lXRThDVEZ3QVN3RlBEVkJKRlNJSklsaGNJRXNCVHd4UVNSVWlDU0pZWEVCTEFVOExVRWtWSWdraVdGeGdTd0ZQQ2xCSkZTSUpJbGhjZ0VzQlR3bFFTUlVpQ1NKWVhLQkxBVThJVUVrVklna2lXRnpBU3dGUEIxQkpGU0lKSWxoYzRFc0JUd1pRU1JVaUNTSllKRXhkU3dGUEJWQkpGU0lKSWxnbFRGMUxBVThFVUVrVklna2lXSUhBQWt4ZFN3RlBBMUJKRlNJSklsaUI0QUpNWFVsWEFFQkxBVmZBUUZCTEFWZGdJRXNEVEZCSkZTSUpJbGhMQWxkQUlFc0VURkJKRlNJSklsaFFTd0pYb0NCTEJFeFFTUlVpQ1NKWVN3TlhnQ0JMQlV4UVNSVWlDU0pZVUZCTEFpVWlXRXNFVEZCSkZTSUpJbGhMQXlRaVdFc0ZURkJKRlNJSklsaFFTd09CNEFJaVdFc0ZURkJKRlNJSklsaExCSUhBQWlKWVN3Wk1VRWtWSWdraVdGQlFVT0lBZ0FBcFR3Sk5Ud0pNVUVrVklna2lXSUdBQTB4ZFNZR0FBeUpZVERVQUthaUFBUUNCQUU4Q1ZDaE1VTEFqUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
