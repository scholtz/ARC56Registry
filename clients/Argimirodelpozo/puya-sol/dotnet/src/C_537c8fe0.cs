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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_537c8fe0
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class D : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static D Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new D();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vXValue) { ret.X = vXValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as D);
                }
                public bool Equals(D? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(D left, D right)
                {
                    return EqualityComparer<D>.Default.Equals(left, right);
                }
                public static bool operator !=(D left, D right)
                {
                    return !(left == right);
                }

            }

            public class JArgA : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static JArgA Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new JArgA();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as JArgA);
                }
                public bool Equals(JArgA? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(JArgA left, JArgA right)
                {
                    return EqualityComparer<JArgA>.Default.Equals(left, right);
                }
                public static bool operator !=(JArgA left, JArgA right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> D</param>
        public async Task<byte[]> F(Structs.D a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 70, 159, 35 };

            var result = await base.CallApp(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> F_Transactions(Structs.D a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 70, 159, 35 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> D</param>
        public async Task<byte[]> G(Structs.D[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 235, 144, 114 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.D>(x => Structs.D.Parse(x)) { IsFixedLength = true, FixedLength = 2 }; aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> G_Transactions(Structs.D[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 235, 144, 114 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.D>(x => Structs.D.Parse(x)) { IsFixedLength = true, FixedLength = 2 }; aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> H(HArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 164, 56, 152 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256[])[]"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> H_Transactions(HArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 164, 56, 152 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256[])[]"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> I(IArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 43, 204, 150 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256[])[2]"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> I_Transactions(IArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 43, 204, 150 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256[])[2]"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> JArgA</param>
        public async Task<byte[]> J(Structs.JArgA[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 223, 253, 10 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.JArgA>(x => Structs.JArgA.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> J_Transactions(Structs.JArgA[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 223, 253, 10 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.JArgA>(x => Structs.JArgA.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> JArgA</param>
        public async Task<byte[]> K(Structs.JArgA[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 18, 108, 86 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.JArgA>(x => Structs.JArgA.Parse(x)) { IsFixedLength = true, FixedLength = 2 }; aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> K_Transactions(Structs.JArgA[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 18, 108, 86 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.JArgA>(x => Structs.JArgA.Parse(x)) { IsFixedLength = true, FixedLength = 2 }; aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> L(LArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 130, 39, 225 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256)[]"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> L_Transactions(LArgA[][] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 130, 39, 225 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<>("(uint256)[]"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50MjU2W10ifV0sIkpBcmdBIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDI1NltdKSIsInN0cnVjdCI6IkQiLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQyNTZbXSlbMl0iLCJzdHJ1Y3QiOiJEIiwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50MjU2W10pW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50MjU2W10pWzJdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDI1NilbXSIsInN0cnVjdCI6IkpBcmdBIiwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50MjU2KVsyXSIsInN0cnVjdCI6IkpBcmdBIiwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50MjU2KVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0ODAsNTA4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjAsNjc0LDcxMCwxMTM4LDExODQsMTYzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODIsMjM0LDU2MSw2MzcsNzM2LDExMDEsMTE1MCwxMjEwLDE2NjEsMTg5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8Uz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8RD4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8Uz4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxELCAyPj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PEQsIDI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PFMsIDI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMyLDEyMDYsMTY1NywxODc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1aW50MjU2W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxOCwxNjQzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yICgobGVuK3VpbnQyNTZbXSkpWzJdIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKChsZW4rdWludDI1NltdKSlbMl1bXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKChsZW4rdWludDI1NltdKSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbisoKGxlbit1aW50MjU2W10pKVtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rKHVpbnQyNTYpW10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI4LDEyMDIsMTY1MywxODc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OSw0NzIsNTg1LDc4NSwxMjYzLDE2OTksMTkxMF0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZV0pwUlc1amIyUmxjbFl5TDJOaGJHeGtZWFJoWDNOMGNuVmpkRjloY25KaGVWOXlaV1Z1WTI5a1pTNXpiMnd1UXk1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURJZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQ0F3ZURFMU1XWTNZemMxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pIVndiaUF5TUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURNekNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlUZzBOamxtTWpNZ01IZzFaV1ZpT1RBM01pQXdlRGczWVRRek9EazRJREI0WlRZeVltTmpPVFlnTUhnMFltUm1abVF3WVNBd2VHVXlNVEkyWXpVMklEQjRaalE0TWpJM1pURWdMeThnYldWMGFHOWtJQ0ptS0NoMWFXNTBNalUyVzEwcEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaVp5Z29kV2x1ZERJMU5sdGRLVnN5WFNsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW1nb0tIVnBiblF5TlRaYlhTbGJYVnRkS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpYVNnb2RXbHVkREkxTmx0ZEtWc3lYVnRkS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpYWlnb2RXbHVkREkxTmlsYlhTbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltc29LSFZwYm5ReU5UWXBXekpkS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpYkNnb2RXbHVkREkxTmlsYlhWdGRLV0o1ZEdWYlhTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpsOXliM1YwWlVBMUlHMWhhVzVmWjE5eWIzVjBaVUEySUcxaGFXNWZhRjl5YjNWMFpVQTNJRzFoYVc1ZmFWOXliM1YwWlVBNElHMWhhVzVmYWw5eWIzVjBaVUE1SUcxaGFXNWZhMTl5YjNWMFpVQXhNQ0J0WVdsdVgyeGZjbTkxZEdWQU1URUtJQ0FnSUdWeWNnb0tiV0ZwYmw5c1gzSnZkWFJsUURFeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpVS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1luVnllU0F6T0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTlFvS2JXRnBibDltYjNKZmFHVmhaR1Z5UURFMk9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlNd29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOW1iM0pBTVRnS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNemtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyS0hWcGJuUXlOVFlwVzEwcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0F4TmdvS2JXRnBibDloWm5SbGNsOW1iM0pBTVRnNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhUUGo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qRTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVeENpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdZblZ5ZVNBeU1Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0oxY25rZ016SUtJQ0FnSUdKMWNua2dORFFLQ20xaGFXNWZkMmhwYkdWZmRHOXdRREl5T2dvZ0lDQWdaR2xuSURNd0NpQWdJQ0JrYVdjZ01qTUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpZS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBME1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJNENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE15Q2lBZ0lDQmthV2NnTWpNS0lDQWdJRHdLSUNBZ0lHSnVlaUJ0WVdsdVgybG1YMkp2WkhsQU1qUUtJQ0FnSUdScFp5QXhOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJMU9nb2dJQ0FnWkdsbklESTNDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUdScFp5QTBNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlRJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQTFNZ29nSUNBZ1pHbG5JRFExQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEUTJDaUFnSUNCc1pXNEtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Ua0tJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTWpJS0NtMWhhVzVmYVdaZlltOWtlVUF5TkRvS0lDQWdJR1JwWnlBek1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ016a0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpVS0NtMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU1qWTZDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNak1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFV3Q2lBZ0lDQmthV2NnTkRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJd09nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJeENncHRZV2x1WDJ0ZmNtOTFkR1ZBTVRBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05EQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhVeXdnTWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16QUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16RTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBek9Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURBZ016SWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBek1pQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1Rb0tiV0ZwYmw5cVgzSnZkWFJsUURrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05EQUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeFRQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE01Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTFPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTJDZ3B0WVdsdVgybGZjbTkxZEdWQU9Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBNQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJMkNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1luVnllU0F6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1luVnllU0F4TndvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTXpnS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlkWEo1SURVS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBek9Ub0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNalFLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURRMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6T0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5Z29iR1Z1SzNWcGJuUXlOVFpiWFNrcFd6SmRXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWRYSjVJRE0yQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdKMWNua2dOQW9LYldGcGJsOW1iM0pmYUdWaFpHVnlRRFF4T2dvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBME13b2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6TndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNnb2JHVnVLM1ZwYm5ReU5UWmJYU2twV3pKZENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBd0lHOW1JQ2dvYkdWdUszVnBiblF5TlRaYlhTa3BDaUFnSUNCemQyRndDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdZaUJ0WVdsdVgyWnZjbDlvWldGa1pYSkFOREVLQ20xaGFXNWZZV1owWlhKZlptOXlRRFF6T2dvZ0lDQWdaSFZ3TWdvZ0lDQWdLd29nSUNBZ1luVnllU0F5Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU16a0tDbTFoYVc1ZllXWjBaWEpmWm05eVFEUTBPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4RUxDQXlQajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTkRjNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFV6Q2lBZ0lDQmthV2NnTWpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ1luVnllU0F5TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTXpNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBME5nb2dJQ0FnWW5WeWVTQTFNUW9LYldGcGJsOTNhR2xzWlY5MGIzQkFORGc2Q2lBZ0lDQmthV2NnTXpFS0lDQWdJR1JwWnlBeU5Bb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5M2FHbHNaVUExTndvZ0lDQWdaR2xuSURNeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURRd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTWprS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNek1LSUNBZ0lHUnBaeUF5TkFvZ0lDQWdQQW9nSUNBZ1ltNTZJRzFoYVc1ZmFXWmZZbTlrZVVBMU1Bb2dJQ0FnWkdsbklERTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRFNkNpQWdJQ0JrYVdjZ01qZ0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnWkdsbklEUXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUTVDaUFnSUNCc1pXNEtJQ0FnSUdKMWNua2dOd29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWW5WeWVTQTVDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1pHbG5JRFV4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkRFS0lDQWdJR0oxY25rZ05ESUtDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FEVXlPZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMU5nb2dJQ0FnWkdsbklERXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTkRrS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JpZFhKNUlERXlDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdQQW9nSUNBZ1ltNTZJRzFoYVc1ZmFXWmZZbTlrZVVBMU5Bb2dJQ0FnWkdsbklEWUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUExTlRvS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdENpQWdJQ0JrYVdjZ05Ea0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEUTBDaUFnSUNCa2FXY2dOREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05ESUtJQ0FnSUd4bGJnb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpSUcxaGFXNWZkMmhwYkdWZmRHOXdRRFV5Q2dwdFlXbHVYMmxtWDJKdlpIbEFOVFE2Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dORGdLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUExTlFvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMU5qb0tJQ0FnSUdScFp5QTBNUW9nSUNBZ1pHbG5JRFF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURVekNpQWdJQ0JrYVdjZ05EWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTkRjS0lDQWdJR3hsYmdvZ0lDQWdLd29nSUNBZ1luVnllU0F5TUFvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQTBPQW9LYldGcGJsOXBabDlpYjJSNVFEVXdPZ29nSUNBZ1pHbG5JRE14Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6T1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTFNUW9LYldGcGJsOWhablJsY2w5M2FHbHNaVUExTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU5Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05URUtJQ0FnSUdScFp5QTBOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFORFk2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFORGNLQ20xaGFXNWZhRjl5YjNWMFpVQTNPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmlkWEo1SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmlkWEo1SURFNUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZblZ5ZVNBek9Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0oxY25rZ05Rb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEWXdPZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF5TmdvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDltYjNKQU5qVUtJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNNENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLR3hsYmlzb0tHeGxiaXQxYVc1ME1qVTJXMTBwS1Z0ZEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JpZFhKNUlESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlETTNDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5WeWVTQTBDZ3B0WVdsdVgyWnZjbDlvWldGa1pYSkFOakk2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURZS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmWm05eVFEWTBDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNNENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJtYjNJZ0tHeGxiaXNvS0d4bGJpdDFhVzUwTWpVMlcxMHBLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYml0MWFXNTBNalUyVzEwcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEWXlDZ3B0WVdsdVgyRm1kR1Z5WDJadmNrQTJORG9LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQmlJRzFoYVc1ZlptOXlYMmhsWVdSbGNrQTJNQW9LYldGcGJsOWhablJsY2w5bWIzSkFOalU2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeEVQajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpjS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpnNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFUyQ2lBZ0lDQmthV2NnTWpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ1luVnllU0F5TXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTXpVS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBME9Bb2dJQ0FnWW5WeWVTQTFOQW9LYldGcGJsOTNhR2xzWlY5MGIzQkFOams2Q2lBZ0lDQmthV2NnTXpNS0lDQWdJR1JwWnlBeU5nb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5M2FHbHNaVUEzT0FvZ0lDQWdaR2xuSURNekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURRd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTXpFS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNelVLSUNBZ0lHUnBaeUF5TmdvZ0lDQWdQQW9nSUNBZ1ltNTZJRzFoYVc1ZmFXWmZZbTlrZVVBM01Rb2dJQ0FnWkdsbklERTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpJNkNpQWdJQ0JrYVdjZ016QUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnWkdsbklEUXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEVXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREkzQ2lBZ0lDQnNaVzRLSUNBZ0lHSjFjbmtnTVRnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ1luVnllU0F5TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTXpNS0lDQWdJR1JwWnlBMU5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUTNDaUFnSUNCaWRYSjVJRFV6Q2dwdFlXbHVYM2RvYVd4bFgzUnZjRUEzTXpvS0lDQWdJR1JwWnlBek1nb2dJQ0FnWkdsbklESTFDaUFnSUNBOENpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURjM0NpQWdJQ0JrYVdjZ016SUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ05UQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBek1Bb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TkFvZ0lDQWdaR2xuSURJMUNpQWdJQ0E4Q2lBZ0lDQmlibm9nYldGcGJsOXBabDlpYjJSNVFEYzFDaUFnSUNCa2FXY2dNVFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBM05qb0tJQ0FnSUdScFp5QXlPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCa2FXY2dOVEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01qSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMU5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRFUxQ2lBZ0lDQmthV2NnTkRjS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dORGdLSUNBZ0lHeGxiZ29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ1lpQnRZV2x1WDNkb2FXeGxYM1J2Y0VBM013b0tiV0ZwYmw5cFpsOWliMlI1UURjMU9nb2dJQ0FnWkdsbklETXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QTBPUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBM05nb0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQTNOem9LSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TlFvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVMENpQWdJQ0JrYVdjZ05EZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExTmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEVTJDaUFnSUNCa2FXY2dORGdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05Ea0tJQ0FnSUd4bGJnb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeU1nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUEyT1FvS2JXRnBibDlwWmw5aWIyUjVRRGN4T2dvZ0lDQWdaR2xuSURNekNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBek9Rb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEzTWdvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBM09Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXlOZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOVFFLSUNBZ0lHUnBaeUEwT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpjNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpnS0NtMWhhVzVmWjE5eWIzVjBaVUEyT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblZ5ZVNBek9Rb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlkWEo1SURVS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBNE1Ub0tJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5bWIzSkFPRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ05EQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9LR3hsYml0MWFXNTBNalUyVzEwcEtWc3lYUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNQ0J2WmlBb0tHeGxiaXQxYVc1ME1qVTJXMTBwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURneENncHRZV2x1WDJGbWRHVnlYMlp2Y2tBNE16b0tJQ0FnSUdScFp5QXpPQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPUW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBFUXNJREkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURnMk9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EwTkFvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJR0oxY25rZ05ERUtDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FEZzNPZ29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBNU1Rb2dJQ0FnWkdsbklERXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTkRBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JpZFhKNUlERXpDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdQQW9nSUNBZ1ltNTZJRzFoYVc1ZmFXWmZZbTlrZVVBNE9Rb2dJQ0FnWkdsbklEY0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE1TURvS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdENpQWdJQ0JrYVdjZ05EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEUTFDaUFnSUNCa2FXY2dORElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ05ETUtJQ0FnSUd4bGJnb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUE0TndvS2JXRnBibDlwWmw5aWIyUjVRRGc1T2dvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRE01Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RBS0NtMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU9URTZDaUFnSUNCa2FXY2dORElLSUNBZ0lHUnBaeUEwTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGcxT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGcyQ2dwdFlXbHVYMlpmY205MWRHVkFOVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURBZ2IyWWdLQ2hzWlc0cmRXbHVkREkxTmx0ZEtTa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TndvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBckNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJFQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURrMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrMk9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTXpVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdkNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPVFU2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPVFlLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZV0pwUlc1amIyUmxjbFl5TDJOaGJHeGtZWFJoWDNOMGNuVmpkRjloY25KaGVWOXlaV1Z1WTI5a1pTNXpiMnd1UXk1amJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVJQUlBQVNZQ0lBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnQkJVZmZIVWtSeFNBQUVjaGdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBQ0pVTXhHUlJFTVJoRWdnY0VxRWFmSXdSZTY1QnlCSWVrT0pnRTVpdk1sZ1JMMy8wS0JPSVNiRllFOUlJbjRUWWFBSTRIQnA0Rm1RT1lBY2dCZkFFVUFBRUFOaG9CU1VVb1NTUlpTVVVaSXd0RkEwa1ZSUkJYQWdCRkppUkZCVXNFU3hjTVFRQW5Td1JKSXd0TEowbFBBbGxKU3dWSlRnUVNSRXNCRlZJa1dTSUxJd2dJUlFNbENFVUZRdi9SU3dFakNFc1BFa1F4RmtFQXR6RVdKUWs0Q0JSRUpLOUpSVE5MRnlJTFJSUWtSU0JGTEVzZVN4Y01RUUIwU3g1Skl3c2pDRXNvVEZrakNFVWNKUWhKUlNCTEZ3eEFBRXRMRGtzYlNVNENDVXNvVGdKWUlxOUxBUlVqQ1NJS0Zrc0JURkJKRlNJSklsaFBBbGNDQUZCTEZFbE9BeFpQQWt4UVNSVWlDU0pZU3pSTVVFVTBTeTFMQVZCRkxoVUlSUk5DLzVOTEhpTUxJd2hMSjB4Wkl3aEMvNmdpcjBzWEZsQkpGU0lKSWxoTE1rc3RVRkFvVEZCSkZSWlhCZ0pNVUNsTVVMQWxReVJDLzBzMkdnRkpSU2dWZ1VBU1JERVdRUUJVTVJZbENUZ0lGRVFpcjBzblNVNENWd0FnVndBZ1N3Rk1VRWtWSWdraVdFc0JURkJKRlNJSklsaFBBbGNnSUZjQUlFc0NURkJKRlNJSklsaFBBa3hRU1JVaUNTSllVRWtWRmxjR0FreFFLVXhRc0NWREpFTC9yallhQVVsRktFa2tXU0lMSXdoTUZVbEZCUkpFTVJaQkFDOHhGaVVKT0FnVVJDS3ZTd01qQ1NJS0ZsQkpGU0lKSWxoTEoxY0NBRkFvVEZCSkZSWlhCZ0pNVUNsTVVMQWxReVJDLzlNMkdnRkpSU2hKSkZsSlJSb2pDMFVEU1JWRkVWY0NBRVVtSkVVRlN3UkxHQXhCQUdSTEJDTUxTeVpKVHdKWlNVc0VFa1JMQVJWU1JTU0JCRVVCSkVVRVN3TWpERUVBTkVzRFNTTUxTeVZKVHdKWlNVc0VTVTRFRWtSTEFSVlNTUlZMQVNSWlNTTVNSRXhTSkZraUM0RUVDQWhGQWlVSVJRUkMvOFZLQ0VVQ1N3UWxDRVVGUXYrVVN3RWpDRXNRRWtReEZrRUJOekVXSlFrNENCUkVKSzlKUlRWTEdDSUxSUlVrUlNGSlJTNUZNMHNmU3hnTVFRRHhTeDlKSXdzakNFc29URmtqQ0VVZEpRaEpSU0ZMR0F4QUFNaExEMHNjU1U0Q0NVc29UZ0pZU1VVeEZVVUhnVUJGQ1NSRkRVc3pTVVVwUlNwTERDTU1RUUI0U3d4Skl3dExNVXhaUlF3bENFbEZEaU1NUUFCWVN3WkxDMGxPQWdsTE1VNENXQ0t2U3dFa1dVc0NGVThEVGdKU1NSVWpDU0lLRmtzQ1RGQkpGU0lKSWxoTVZ3SUFVQ2hNVUVzS1NVNERGazhDVEZCSkZTSUpJbGhMTEV4UVJTeExLVXNCVUVVcUZRaEZDVUwvakVzTUl3dExNRXhaUXYrZlN5bExLRkFpcjBzVlNVNERGbEJKRlNJSklsaExOVXhRUlRWTExrc0JVRVV2RlFoRkZFTC9Ga3NmSXdzakNFc25URmtqQ0VML0t5S3ZTeGdXVUVrVklna2lXRXN6U3k1UVVDaE1VRWtWRmxjR0FreFFLVXhRc0NWREpFTCt5ellhQVVsRktFa2tXVWxGSENNTFJRTkpGVVVUVndJQVJTWWtSUVZMQkVzYURFRUFja3NFSXd0TEprbFBBbGxKU3dRU1JFc0JGVkpKSkZsSlJRZ2pDMFVDVndJQVJTVWtSUVJMQTBzR0RFRUFORXNEU1NNTFN5WkpUd0paU1VzRVNVNEVFa1JMQVJWU1NSVkxBU1JaU1NNU1JFeFNKRmtpQzRFRUNBaEZBaVVJUlFSQy84UkpJd2hMQWdoRkFrc0VKUWhGQlVML2hrc0JJd2hMRWhKRU1SWkJBVm94RmlVSk9BZ1VSQ1N2U1VVNFN4b2lDMFVYSkVValNVVXdSVFpMSVVzYURFRUJGRXNoU1NNTEl3aExLRXhaSXdoRkh5VUlTVVVqU3hvTVFBRHJTeEZMSGtsT0FnbExLRTRDV0VsRk1ra2tXVWxPQWtVYkZVVVNJZ3RGRlNSRklVczJTVVV2UlRWTElFc1pERUVBZ1VzZ1NTTUxJd2hMTWt4Wkl3aEZIaVVJU1VVaVN4a01RQUJZU3hCTEhVbE9BZ2xMTWs0Q1dDS3ZTd0VrV1VzQ0ZVOERUZ0pTU1JVakNTSUtGa3NDVEZCSkZTSUpJbGhNVndJQVVDaE1VRXNXU1U0REZrOENURkJKRlNJSklsaExOMHhRUlRkTEwwc0JVRVV3RlFoRkZVTC9oa3NnSXdzakNFc3hURmtqQ0VML215S3ZTeGtXU3dGTVVFa1ZJZ2tpV0VzMlN6QlFVRXNYU1U0REZrOENURkJKRlNJSklsaExPRXhRUlRoTE1Fc0JVRVV4RlFoRkZrTCs4MHNoSXdzakNFc25URmtqQ0VML0NDS3ZTeG9XVUVrVklna2lXRXMyU3pCUVVDaE1VRWtWRmxjR0FreFFLVXhRc0NWREpFTCtxRFlhQVVVbmdRUkZBaVJGQlVzRUl3eEJBRFJMQkVrakMwc29TVThDV1VsTEJVbE9CQkpFU3dFVlVra1ZTd0VrV1VrakVrUk1VaVJaSWd1QkJBZ0lSUU1sQ0VVRlF2L0ZTeVlWU1VVSlN3SVNSREVXUVFDck1SWWxDVGdJRkVRa3IwbEZMSUZBUlFza1JROUZLVXNOSXd4QkFIaExEVWtqQzBzb1RGbEZEU1VJU1VVUEl3eEFBRmhMQjBzTVNVNENDVXNvVGdKWUlxOUxBU1JaU3dJVlR3Tk9BbEpKRlNNSklnb1dTd0pNVUVrVklna2lXRXhYQWdCUUtFeFFTd3RKVGdNV1R3Sk1VRWtWSWdraVdFc3RURkJGTFVzcVN3RlFSU3NWQ0VVS1F2K01TdzBqQzBzblRGbEMvNTlMS2tzcFVDaE1VRWtWRmxjR0FreFFLVXhRc0NWREpFTC9WellhQVVrVlN3RWtXVWtqRWtSUEFreExBbEpKUlNVa1dTSUxnUVFJRWtReEZrRUFjekVXSlFrNENCUkVJcTlMSTBsT0FoVWpDU0lLRmxCSkZTSUpJbGhNVndJQVVJQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJRXhRU1JVV1Z3WUNURkFwVEZDd0pVTWtRditQIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
