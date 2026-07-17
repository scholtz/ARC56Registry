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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.CryptoOpsContract_bf9e8ee3
{


    public class CryptoOpsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CryptoOpsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VerifyEcdsaRecoverK1Return : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerifyEcdsaRecoverK1Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VerifyEcdsaRecoverK1Return();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerifyEcdsaRecoverK1Return);
                }
                public bool Equals(VerifyEcdsaRecoverK1Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifyEcdsaRecoverK1Return left, VerifyEcdsaRecoverK1Return right)
                {
                    return EqualityComparer<VerifyEcdsaRecoverK1Return>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifyEcdsaRecoverK1Return left, VerifyEcdsaRecoverK1Return right)
                {
                    return !(left == right);
                }

            }

            public class VerifyVrfVerifyReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerifyVrfVerifyReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VerifyVrfVerifyReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerifyVrfVerifyReturn);
                }
                public bool Equals(VerifyVrfVerifyReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifyVrfVerifyReturn left, VerifyVrfVerifyReturn right)
                {
                    return EqualityComparer<VerifyVrfVerifyReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifyVrfVerifyReturn left, VerifyVrfVerifyReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="pad_size"> </param>
        public async Task<byte[]> VerifySha256(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 86, 196, 195 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifySha256_Transactions(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 86, 196, 195 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="pad_size"> </param>
        public async Task<byte[]> VerifySha3256(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 68, 43, 132 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifySha3256_Transactions(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 68, 43, 132 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="pad_size"> </param>
        public async Task<byte[]> VerifyKeccak256(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 245, 103, 170 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifyKeccak256_Transactions(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 245, 103, 170 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="pad_size"> </param>
        public async Task<byte[]> VerifySha512256(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 132, 85, 177 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VerifySha512256_Transactions(byte[] a, ulong pad_size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 132, 85, 177 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var pad_sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pad_sizeAbi.From(pad_size);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, pad_sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task<bool> VerifyEd25519Verify(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 175, 15, 56 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEd25519Verify_Transactions(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 175, 15, 56 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task<bool> VerifyEd25519VerifyBare(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 130, 201, 151 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEd25519VerifyBare_Transactions(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 130, 201, 151 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> </param>
        /// <param name="e"> </param>
        public async Task<bool> VerifyEcdsaVerifyK1(byte[] a, byte[] b, byte[] c, byte[] d, byte[] e, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 152, 255, 187 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);
            var eAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); eAbi.From(e);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi, eAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEcdsaVerifyK1_Transactions(byte[] a, byte[] b, byte[] c, byte[] d, byte[] e, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 152, 255, 187 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);
            var eAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); eAbi.From(e);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi, eAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> </param>
        /// <param name="e"> </param>
        public async Task<bool> VerifyEcdsaVerifyR1(byte[] a, byte[] b, byte[] c, byte[] d, byte[] e, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 133, 181, 79 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);
            var eAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); eAbi.From(e);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi, eAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEcdsaVerifyR1_Transactions(byte[] a, byte[] b, byte[] c, byte[] d, byte[] e, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 133, 181, 79 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);
            var eAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); eAbi.From(e);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi, eAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> </param>
        public async Task<Structs.VerifyEcdsaRecoverK1Return> VerifyEcdsaRecoverK1(byte[] a, ulong b, byte[] c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 100, 224, 191 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyEcdsaRecoverK1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyEcdsaRecoverK1_Transactions(byte[] a, ulong b, byte[] c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 100, 224, 191 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Must fail, AVM does not support Secp256r1 for recover
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> </param>
        public async Task<Structs.VerifyEcdsaRecoverK1Return> VerifyEcdsaRecoverR1(byte[] a, ulong b, byte[] c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 91, 121, 165 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyEcdsaRecoverK1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyEcdsaRecoverR1_Transactions(byte[] a, ulong b, byte[] c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 91, 121, 165 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Structs.VerifyEcdsaRecoverK1Return> VerifyEcdsaDecompressK1(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 107, 176, 119 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyEcdsaRecoverK1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyEcdsaDecompressK1_Transactions(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 107, 176, 119 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<Structs.VerifyEcdsaRecoverK1Return> VerifyEcdsaDecompressR1(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 63, 140, 204 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyEcdsaRecoverK1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyEcdsaDecompressR1_Transactions(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 63, 140, 204 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task<Structs.VerifyVrfVerifyReturn> VerifyVrfVerify(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 124, 104, 169 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyVrfVerifyReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyVrfVerify_Transactions(byte[] a, byte[] b, byte[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 124, 104, 169 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3J5cHRvT3BzQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVmVyaWZ5RWNkc2FSZWNvdmVySzFSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJ5dGVbXSJ9XSwiVmVyaWZ5VnJmVmVyaWZ5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InZlcmlmeV9zaGEyNTYiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFkX3NpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfc2hhM18yNTYiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFkX3NpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfa2VjY2FrXzI1NiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYWRfc2l6ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9zaGE1MTJfMjU2IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhZF9zaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2VkMjU1MTl2ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfZWQyNTUxOXZlcmlmeV9iYXJlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2VjZHNhX3ZlcmlmeV9rMSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9lY2RzYV92ZXJpZnlfcjEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfZWNkc2FfcmVjb3Zlcl9rMSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sYnl0ZVtdKSIsInN0cnVjdCI6IlZlcmlmeUVjZHNhUmVjb3ZlcksxUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2VjZHNhX3JlY292ZXJfcjEiLCJkZXNjIjoiTXVzdCBmYWlsLCBBVk0gZG9lcyBub3Qgc3VwcG9ydCBTZWNwMjU2cjEgZm9yIHJlY292ZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJWZXJpZnlFY2RzYVJlY292ZXJLMVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9lY2RzYV9kZWNvbXByZXNzX2sxIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSxieXRlW10pIiwic3RydWN0IjoiVmVyaWZ5RWNkc2FSZWNvdmVySzFSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfZWNkc2FfZGVjb21wcmVzc19yMSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sYnl0ZVtdKSIsInN0cnVjdCI6IlZlcmlmeUVjZHNhUmVjb3ZlcksxUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X3ZyZl92ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLGJvb2wpIiwic3RydWN0IjoiVmVyaWZ5VnJmVmVyaWZ5UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNekF3TUNBMENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZ3dNQ0F3ZURFMU1XWTNZemMxTURBeU1DQXdlREF3TURRZ01IZ3dOamd4TURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTNKNWNIUnZUM0J6UTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREl3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TkRVMll6UmpNeUF3ZUdVNE5EUXlZamcwSURCNE5qVm1OVFkzWVdFZ01IZ3lOVGcwTlRWaU1TQXdlRE0xWVdZd1pqTTRJREI0TmpVNE1tTTVPVGNnTUhnMk1qazRabVppWWlBd2VETTRPRFZpTlRSbUlEQjRNakUyTkdVd1ltWWdNSGczTlRWaU56bGhOU0F3ZUdZd05tSmlNRGMzSURCNE1UTXpaamhqWTJNZ01IZ3laamRqTmpoaE9TQXZMeUJ0WlhSb2IyUWdJblpsY21sbWVWOXphR0V5TlRZb1lubDBaVnRkTEhWcGJuUTJOQ2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOXphR0V6WHpJMU5paGllWFJsVzEwc2RXbHVkRFkwS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMnRsWTJOaGExOHlOVFlvWW5sMFpWdGRMSFZwYm5RMk5DbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5emFHRTFNVEpmTWpVMktHSjVkR1ZiWFN4MWFXNTBOalFwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZaV1F5TlRVeE9YWmxjbWxtZVNoaWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWldReU5UVXhPWFpsY21sbWVWOWlZWEpsS0dKNWRHVmJYU3hpZVhSbFcxMHNZbmwwWlZ0ZEtXSnZiMndpTENCdFpYUm9iMlFnSW5abGNtbG1lVjlsWTJSellWOTJaWEpwWm5sZmF6RW9ZbmwwWlZ0ZExHSjVkR1ZiWFN4aWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWldOa2MyRmZkbVZ5YVdaNVgzSXhLR0o1ZEdWYlhTeGllWFJsVzEwc1lubDBaVnRkTEdKNWRHVmJYU3hpZVhSbFcxMHBZbTl2YkNJc0lHMWxkR2h2WkNBaWRtVnlhV1o1WDJWalpITmhYM0psWTI5MlpYSmZhekVvWW5sMFpWdGRMSFZwYm5RMk5DeGllWFJsVzEwc1lubDBaVnRkS1NoaWVYUmxXMTBzWW5sMFpWdGRLU0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMlZqWkhOaFgzSmxZMjkyWlhKZmNqRW9ZbmwwWlZ0ZExIVnBiblEyTkN4aWVYUmxXMTBzWW5sMFpWdGRLU2hpZVhSbFcxMHNZbmwwWlZ0ZEtTSXNJRzFsZEdodlpDQWlkbVZ5YVdaNVgyVmpaSE5oWDJSbFkyOXRjSEpsYzNOZmF6RW9ZbmwwWlZ0ZEtTaGllWFJsVzEwc1lubDBaVnRkS1NJc0lHMWxkR2h2WkNBaWRtVnlhV1o1WDJWalpITmhYMlJsWTI5dGNISmxjM05mY2pFb1lubDBaVnRkS1NoaWVYUmxXMTBzWW5sMFpWdGRLU0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYM1p5Wmw5MlpYSnBabmtvWW5sMFpWdGRMR0o1ZEdWYlhTeGllWFJsVzEwcEtHSjVkR1ZiWFN4aWIyOXNLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhabGNtbG1lVjl6YUdFeU5UWWdkbVZ5YVdaNVgzTm9ZVE5mTWpVMklIWmxjbWxtZVY5clpXTmpZV3RmTWpVMklIWmxjbWxtZVY5emFHRTFNVEpmTWpVMklIWmxjbWxtZVY5bFpESTFOVEU1ZG1WeWFXWjVJSFpsY21sbWVWOWxaREkxTlRFNWRtVnlhV1o1WDJKaGNtVWdkbVZ5YVdaNVgyVmpaSE5oWDNabGNtbG1lVjlyTVNCMlpYSnBabmxmWldOa2MyRmZkbVZ5YVdaNVgzSXhJSFpsY21sbWVWOWxZMlJ6WVY5eVpXTnZkbVZ5WDJzeElIWmxjbWxtZVY5bFkyUnpZVjl5WldOdmRtVnlYM0l4SUhabGNtbG1lVjlsWTJSellWOWtaV052YlhCeVpYTnpYMnN4SUhabGNtbG1lVjlsWTJSellWOWtaV052YlhCeVpYTnpYM0l4SUhabGNtbG1lVjkyY21aZmRtVnlhV1o1Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qQTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNTFkR2xzTG1WdWMzVnlaVjlpZFdSblpYUW9jbVZ4ZFdseVpXUmZZblZrWjJWME9pQjFhVzUwTmpRc0lHWmxaVjl6YjNWeVkyVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0taVzV6ZFhKbFgySjFaR2RsZERvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0FyQ2dwbGJuTjFjbVZmWW5Wa1oyVjBYM2RvYVd4bFgzUnZjRUF4T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHZHNiMkpoYkNCUGNHTnZaR1ZDZFdSblpYUUtJQ0FnSUQ0S0lDQWdJR0o2SUdWdWMzVnlaVjlpZFdSblpYUmZZV1owWlhKZmQyaHBiR1ZBTmdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURZNE1UQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4zYVhSamFDQmxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6QkFNeUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekZBTkFvS1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFU2Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQmxibk4xY21WZlluVmtaMlYwWDNkb2FXeGxYM1J2Y0VBeENncGxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6RkFORG9LSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JpSUdWdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFDZ3BsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekJBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Rb0taVzV6ZFhKbFgySjFaR2RsZEY5aFpuUmxjbDkzYUdsc1pVQTJPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrTnllWEIwYjA5d2N5NWpiMjUwY21GamRDNURjbmx3ZEc5UGNITkRiMjUwY21GamRDNTJaWEpwWm5sZmMyaGhNalUyVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDNOb1lUSTFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OURjbmx3ZEc5UGNITXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSjVjSFJ2VDNCekwyTnZiblJ5WVdOMExuQjVPamNLSUNBZ0lDOHZJR0VnUFNCdmNDNWllbVZ5Ynlod1lXUmZjMmw2WlNrZ0t5QmhDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0o1Y0hSdlQzQnpMMk52Ym5SeVlXTjBMbkI1T2pnS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUc5d0xuTm9ZVEkxTmloaEtRb2dJQ0FnYzJoaE1qVTJDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSjVjSFJ2VDNCekwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VXdNREl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NURjbmx3ZEc5UGNITXVZMjl1ZEhKaFkzUXVRM0o1Y0hSdlQzQnpRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgzTm9ZVE5mTWpVMlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVgzTm9ZVE5mTWpVMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qRXpDaUFnSUNBdkx5QmhJRDBnYjNBdVlucGxjbThvY0dGa1gzTnBlbVVwSUNzZ1lRb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnY21WemRXeDBJRDBnYjNBdWMyaGhNMTh5TlRZb1lTa0tJQ0FnSUhOb1lUTmZNalUyQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0o1Y0hSdlQzQnpMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxTURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11UTNKNWNIUnZUM0J6TG1OdmJuUnlZV04wTGtOeWVYQjBiMDl3YzBOdmJuUnlZV04wTG5abGNtbG1lVjlyWldOallXdGZNalUyVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1WDJ0bFkyTmhhMTh5TlRZNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklHRWdQU0J2Y0M1aWVtVnlieWh3WVdSZmMybDZaU2tnS3lCaENpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSjVjSFJ2VDNCekwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0J2Y0M1clpXTmpZV3N5TlRZb1lTa0tJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMME55ZVhCMGIwOXdjeTlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlRBd01qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtOeWVYQjBiMDl3Y3k1amIyNTBjbUZqZEM1RGNubHdkRzlQY0hORGIyNTBjbUZqZEM1MlpYSnBabmxmYzJoaE5URXlYekkxTmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5emFHRTFNVEpmTWpVMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmhJRDBnYjNBdVlucGxjbThvY0dGa1gzTnBlbVVwSUNzZ1lRb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnY21WemRXeDBJRDBnYjNBdWMyaGhOVEV5WHpJMU5paGhLUW9nSUNBZ2MyaGhOVEV5WHpJMU5nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrTnllWEIwYjA5d2N5NWpiMjUwY21GamRDNURjbmx3ZEc5UGNITkRiMjUwY21GamRDNTJaWEpwWm5sZlpXUXlOVFV4T1habGNtbG1lVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVjlsWkRJMU5URTVkbVZ5YVdaNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OURjbmx3ZEc5UGNITXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdWdWMzVnlaVjlpZFdSblpYUW9NVGt3TUN3Z1QzQlZjRVpsWlZOdmRYSmpaUzVIY205MWNFTnlaV1JwZENrS0lDQWdJSEIxYzJocGJuUWdNVGt3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnY21WemRXeDBJRDBnYjNBdVpXUXlOVFV4T1habGNtbG1lU2hoTENCaUxDQmpLUW9nSUNBZ1pXUXlOVFV4T1habGNtbG1lUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2h5WlhOMWJIUXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11UTNKNWNIUnZUM0J6TG1OdmJuUnlZV04wTGtOeWVYQjBiMDl3YzBOdmJuUnlZV04wTG5abGNtbG1lVjlsWkRJMU5URTVkbVZ5YVdaNVgySmhjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmWldReU5UVXhPWFpsY21sbWVWOWlZWEpsT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMME55ZVhCMGIwOXdjeTlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNubHdkRzlQY0hNdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJR1Z1YzNWeVpWOWlkV1JuWlhRb01Ua3dNQ3dnVDNCVmNFWmxaVk52ZFhKalpTNUhjbTkxY0VOeVpXUnBkQ2tLSUNBZ0lIQjFjMmhwYm5RZ01Ua3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdOaGJHeHpkV0lnWlc1emRYSmxYMkoxWkdkbGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdiM0F1WldReU5UVXhPWFpsY21sbWVWOWlZWEpsS0dFc0lHSXNJR01wQ2lBZ0lDQmxaREkxTlRFNWRtVnlhV1o1WDJKaGNtVUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNubHdkRzlQY0hNdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29jbVZ6ZFd4MEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMa055ZVhCMGIwOXdjeTVqYjI1MGNtRmpkQzVEY25sd2RHOVBjSE5EYjI1MGNtRmpkQzUyWlhKcFpubGZaV05rYzJGZmRtVnlhV1o1WDJzeFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVgyVmpaSE5oWDNabGNtbG1lVjlyTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklHVnVjM1Z5WlY5aWRXUm5aWFFvTXpBd01Dd2dUM0JWY0VabFpWTnZkWEpqWlM1SGNtOTFjRU55WldScGRDa0tJQ0FnSUdsdWRHTmZNaUF2THlBek1EQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJsYm5OMWNtVmZZblZrWjJWMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnlaWE4xYkhSZmF6RWdQU0J2Y0M1bFkyUnpZVjkyWlhKcFpua29iM0F1UlVORVUwRXVVMlZqY0RJMU5tc3hMQ0JoTENCaUxDQmpMQ0JrTENCbEtRb2dJQ0FnWldOa2MyRmZkbVZ5YVdaNUlGTmxZM0F5TlRack1Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMa055ZVhCMGIwOXdjeTVqYjI1MGNtRmpkQzVEY25sd2RHOVBjSE5EYjI1MGNtRmpkQzUyWlhKcFpubGZaV05rYzJGZmRtVnlhV1o1WDNJeFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVgyVmpaSE5oWDNabGNtbG1lVjl5TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY25sd2RHOVBjSE12WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHVnVjM1Z5WlY5aWRXUm5aWFFvTXpBd01Dd2dUM0JWY0VabFpWTnZkWEpqWlM1SGNtOTFjRU55WldScGRDa0tJQ0FnSUdsdWRHTmZNaUF2THlBek1EQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJsYm5OMWNtVmZZblZrWjJWMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnlaWE4xYkhSZmNqRWdQU0J2Y0M1bFkyUnpZVjkyWlhKcFpua29iM0F1UlVORVUwRXVVMlZqY0RJMU5uSXhMQ0JoTENCaUxDQmpMQ0JrTENCbEtRb2dJQ0FnWldOa2MyRmZkbVZ5YVdaNUlGTmxZM0F5TlRaeU1Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMa055ZVhCMGIwOXdjeTVqYjI1MGNtRmpkQzVEY25sd2RHOVBjSE5EYjI1MGNtRmpkQzUyWlhKcFpubGZaV05rYzJGZmNtVmpiM1psY2w5ck1WdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOWxZMlJ6WVY5eVpXTnZkbVZ5WDJzeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OURjbmx3ZEc5UGNITXZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUdWdWMzVnlaVjlpZFdSblpYUW9NekF3TUN3Z1QzQlZjRVpsWlZOdmRYSmpaUzVIY205MWNFTnlaV1JwZENrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmxibk4xY21WZlluVmtaMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0o1Y0hSdlQzQnpMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVpXTmtjMkZmY0d0ZmNtVmpiM1psY2lodmNDNUZRMFJUUVM1VFpXTndNalUyYXpFc0lHRXNJR0lzSUdNc0lHUXBDaUFnSUNCbFkyUnpZVjl3YTE5eVpXTnZkbVZ5SUZObFkzQXlOVFpyTVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMME55ZVhCMGIwOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrTnllWEIwYjA5d2N5NWpiMjUwY21GamRDNURjbmx3ZEc5UGNITkRiMjUwY21GamRDNTJaWEpwWm5sZlpXTmtjMkZmY21WamIzWmxjbDl5TVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5bFkyUnpZVjl5WldOdmRtVnlYM0l4T2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMME55ZVhCMGIwOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNubHdkRzlQY0hNdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJR1Z1YzNWeVpWOWlkV1JuWlhRb016QXdNQ3dnVDNCVmNFWmxaVk52ZFhKalpTNUhjbTkxY0VOeVpXUnBkQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXpNREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCbGJuTjFjbVZmWW5Wa1oyVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSjVjSFJ2VDNCekwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1WldOa2MyRmZjR3RmY21WamIzWmxjaWh2Y0M1RlEwUlRRUzVUWldOd01qVTJjakVzSUdFc0lHSXNJR01zSUdRcENpQWdJQ0JsWTJSellWOXdhMTl5WldOdmRtVnlJRk5sWTNBeU5UWnlNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtOeWVYQjBiMDl3Y3k1amIyNTBjbUZqZEM1RGNubHdkRzlQY0hORGIyNTBjbUZqZEM1MlpYSnBabmxmWldOa2MyRmZaR1ZqYjIxd2NtVnpjMTlyTVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5bFkyUnpZVjlrWldOdmJYQnlaWE56WDJzeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5Qmxibk4xY21WZlluVmtaMlYwS0Rjd01Dd2dUM0JWY0VabFpWTnZkWEpqWlM1SGNtOTFjRU55WldScGRDa0tJQ0FnSUhCMWMyaHBiblFnTnpBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmxibk4xY21WZlluVmtaMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0o1Y0hSdlQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVpXTmtjMkZmY0d0ZlpHVmpiMjF3Y21WemN5aHZjQzVGUTBSVFFTNVRaV053TWpVMmF6RXNJR0VwQ2lBZ0lDQmxZMlJ6WVY5d2ExOWtaV052YlhCeVpYTnpJRk5sWTNBeU5UWnJNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtOeWVYQjBiMDl3Y3k1amIyNTBjbUZqZEM1RGNubHdkRzlQY0hORGIyNTBjbUZqZEM1MlpYSnBabmxmWldOa2MyRmZaR1ZqYjIxd2NtVnpjMTl5TVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5bFkyUnpZVjlrWldOdmJYQnlaWE56WDNJeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5Qmxibk4xY21WZlluVmtaMlYwS0Rjd01Dd2dUM0JWY0VabFpWTnZkWEpqWlM1SGNtOTFjRU55WldScGRDa0tJQ0FnSUhCMWMyaHBiblFnTnpBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmxibk4xY21WZlluVmtaMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0o1Y0hSdlQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVpXTmtjMkZmY0d0ZlpHVmpiMjF3Y21WemN5aHZjQzVGUTBSVFFTNVRaV053TWpVMmNqRXNJR0VwQ2lBZ0lDQmxZMlJ6WVY5d2ExOWtaV052YlhCeVpYTnpJRk5sWTNBeU5UWnlNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtOeWVYQjBiMDl3Y3k1amIyNTBjbUZqZEM1RGNubHdkRzlQY0hORGIyNTBjbUZqZEM1MlpYSnBabmxmZG5KbVgzWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5MmNtWmZkbVZ5YVdaNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeWVYQjBiMDl3Y3k5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OURjbmx3ZEc5UGNITXZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUdWdWMzVnlaVjlpZFdSblpYUW9OVGN3TUN3Z1QzQlZjRVpsWlZOdmRYSmpaUzVIY205MWNFTnlaV1JwZENrS0lDQWdJSEIxYzJocGJuUWdOVGN3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnllWEIwYjA5d2N5OWpiMjUwY21GamRDNXdlVG80TXdvZ0lDQWdMeThnY21WemRXeDBJRDBnYjNBdWRuSm1YM1psY21sbWVTaHZjQzVXY21aV1pYSnBabmt1Vm5KbVFXeG5iM0poYm1Rc0lHRXNJR0lzSUdNcENpQWdJQ0IyY21aZmRtVnlhV1o1SUZaeVprRnNaMjl5WVc1a0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKNWNIUnZUM0J6TDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFHNEZ3UW1CUVFWSDN4MUFRQUdGUjk4ZFFBZ0FnQUVBd2FCQVRFYlFRQnFNUmtVUkRFWVJJSU5CRFJXeE1NRTZFUXJoQVJsOVdlcUJDV0VWYkVFTmE4UE9BUmxnc21YQkdLWS83c0VPSVcxVHdRaFpPQy9CSFZiZWFVRThHdXdkd1FUUDR6TUJDOThhS2syR2dDT0RRQkVBRmdBYkFDQUFKUUF1UURlQVE0QlBnR0dBYzRDQ0FKQ0FERVpGREVZRkJCRGlnSUFpLzZCQ2dpTEFESU1EVUVBS3JHQkJySVFnUVd5R1NjRXNoNG5CTElmaS8rTkFnQUxBQVN6UXYvYk1nQ3lBVUwvOVNLeUFVTC83NGsyR2dGWEFnQTJHZ0lYcjB4UUFTcE1VTEFqUXpZYUFWY0NBRFlhQWhldlRGQ1lLa3hRc0NORE5ob0JWd0lBTmhvQ0Y2OU1VQUlxVEZDd0kwTTJHZ0ZYQWdBMkdnSVhyMHhRQXlwTVVMQWpRellhQVZjQ0FEWWFBbGNDQURZYUExY0NBSUhzRGlLSS8xd0VLU0pQQWxRb1RGQ3dJME0yR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0NCN0E0aWlQODNoQ2tpVHdKVUtFeFFzQ05ETmhvQlZ3SUFOaG9DVndJQU5ob0RWd0lBTmhvRVZ3SUFOaG9GVndJQUpDS0kvd2dGQUNraVR3SlVLRXhRc0NORE5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBTmhvRlZ3SUFKQ0tJL3RnRkFTa2lUd0pVS0V4UXNDTkROaG9CVndJQU5ob0NGellhQTFjQ0FEWWFCRmNDQUNRaWlQNndCd0JMQVJVV1Z3WUNUd0pRU1JVbENFc0NGUlpYQmdKUEExQk1GbGNHQWl0TVVFOENVRXhRS0V4UXNDTkROaG9CVndJQU5ob0NGellhQTFjQ0FEWWFCRmNDQUNRaWlQNW9Cd0ZMQVJVV1Z3WUNUd0pRU1JVbENFc0NGUlpYQmdKUEExQk1GbGNHQWl0TVVFOENVRXhRS0V4UXNDTkROaG9CVndJQWdid0ZJb2orTGdZQVN3RVZGbGNHQWs4Q1VFa1ZKUWhMQWhVV1Z3WUNUd05RVEJaWEJnSXJURkJQQWxCTVVDaE1VTEFqUXpZYUFWY0NBSUc4QlNLSS9mUUdBVXNCRlJaWEJnSlBBbEJKRlNVSVN3SVZGbGNHQWs4RFVFd1dWd1lDSzB4UVR3SlFURkFvVEZDd0kwTTJHZ0ZYQWdBMkdnSlhBZ0EyR2dOWEFnQ0J4Q3dpaVAydTBBQkxBUlVXVndZQ1R3SlFLU0pQQTFTQUFnQURURkJNVUNoTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
