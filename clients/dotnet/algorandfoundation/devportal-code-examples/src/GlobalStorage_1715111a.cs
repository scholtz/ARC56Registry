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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.GlobalStorage_1715111a
{


    public class GlobalStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GlobalStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MaybeGlobalStateReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static MaybeGlobalStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MaybeGlobalStateReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as MaybeGlobalStateReturn);
                }
                public bool Equals(MaybeGlobalStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeGlobalStateReturn left, MaybeGlobalStateReturn right)
                {
                    return EqualityComparer<MaybeGlobalStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeGlobalStateReturn left, MaybeGlobalStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 22, 208, 131 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 22, 208, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.MaybeGlobalStateReturn> MaybeGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 226, 225, 40 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeGlobalStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 226, 225, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> GetGlobalStateExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 102, 88, 120 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetGlobalStateExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 102, 88, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> MaybeGlobalStateExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 152, 105, 218 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MaybeGlobalStateExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 152, 105, 218 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> CheckGlobalStateExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 164, 244, 105 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckGlobalStateExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 164, 244, 105 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task SetGlobalState(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 109, 68, 132 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobalState_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 109, 68, 132 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value_bytes"> </param>
        /// <param name="value_asset"> </param>
        /// <param name="value_bool"> </param>
        public async Task SetGlobalStateExample(byte[] value_bytes, ulong value_asset, bool value_bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 11, 56, 114 };
            var value_bytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_bytesAbi.From(value_bytes);
            var value_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_assetAbi.From(value_asset);
            var value_boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); value_boolAbi.From(value_bool);

            var result = await base.CallApp(new List<object> { abiHandle, value_bytesAbi, value_assetAbi, value_boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobalStateExample_Transactions(byte[] value_bytes, ulong value_asset, bool value_bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 11, 56, 114 };
            var value_bytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_bytesAbi.From(value_bytes);
            var value_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_assetAbi.From(value_asset);
            var value_boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); value_boolAbi.From(value_bool);

            return await base.MakeTransactionList(new List<object> { abiHandle, value_bytesAbi, value_assetAbi, value_boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> DelGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 234, 227, 14 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DelGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 234, 227, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> DelGlobalStateExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 208, 93, 90 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DelGlobalStateExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 208, 93, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2xvYmFsU3RvcmFnZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNYXliZUdsb2JhbFN0YXRlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldF9nbG9iYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXliZV9nbG9iYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxib29sKSIsInN0cnVjdCI6Ik1heWJlR2xvYmFsU3RhdGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZ2xvYmFsX3N0YXRlX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWF5YmVfZ2xvYmFsX3N0YXRlX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tfZ2xvYmFsX3N0YXRlX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2dsb2JhbF9zdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZ2xvYmFsX3N0YXRlX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfYnl0ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlX2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfYm9vbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxfZ2xvYmFsX3N0YXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbF9nbG9iYWxfc3RhdGVfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NywiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU3OV0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nbG9iYWxfYWNjb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9hcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9hc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9ib29sX3NpbXBsaWZpZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nbG9iYWxfYnl0ZXNfZnVsbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9ieXRlc19zaW1wbGlmaWVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ2xvYmFsX2ludF9mdWxsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMyw1MDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9pbnRfc2ltcGxpZmllZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01UQWdOVEFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbWRzYjJKaGJGOXBiblJmWm5Wc2JDSWdNSGcwT0RZMU5tTTJZelptSUNKbmJHOWlZV3hmWW5sMFpYTmZablZzYkNJZ01IZ3hOVEZtTjJNM05UZ3dJQ0puYkc5aVlXeGZZbTl2YkY5dWIxOWtaV1poZFd4MElpQWlaMnh2WW1Gc1gyRnpjMlYwSWlBaVoyeHZZbUZzWDJsdWRGOXphVzF3YkdsbWFXVmtJaUFpWjJ4dlltRnNYMko1ZEdWelgyNXZYMlJsWm1GMWJIUWlJQ0puYkc5aVlXeGZZbmwwWlhOZmMybHRjR3hwWm1sbFpDSWdJbWRzYjJKaGJGOWliMjlzWDNOcGJYQnNhV1pwWldRaUlEQjRNVFV4Wmpkak56VWdJbWRzYjJKaGJGOXBiblJmYm05ZlpHVm1ZWFZzZENJZ0ltZHNiMkpoYkY5aGNIQnNhV05oZEdsdmJpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnYzJWc1ppNW5iRzlpWVd4ZmFXNTBYMloxYkd3Z1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9OVEFwS1NBZ0l5QlZTVzUwTmpRZ2QybDBhQ0JrWldaaGRXeDBJSFpoYkhWbElEMGdOVEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWRzYjJKaGJGOXBiblJmWm5Wc2JDSUtJQ0FnSUdsdWRHTmZNeUF2THlBMU1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z2MyVnNaaTVuYkc5aVlXeGZhVzUwWDNOcGJYQnNhV1pwWldRZ1BTQlZTVzUwTmpRb0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmJHOWlZV3hmYVc1MFgzTnBiWEJzYVdacFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UY3RNVGtLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZbUZzWDJsdWRGOXphVzF3YkdsbWFXVmtJRDBnVlVsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSURFd0NpQWdJQ0F2THlBcElDQWpJRlZKYm5RMk5DQnphVzF3YkdsbWFXVmtJSGRwZEdnZ1pHVm1ZWFZzZENCMllXeDFaU0E5SURFd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJdE1qTUtJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dTVTVKVkY5Q1dWUkZVd29nSUNBZ0x5OGdjMlZzWmk1bmJHOWlZV3hmWW5sMFpYTmZablZzYkNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlaMnh2WW1Gc1gySjVkR1Z6WDJaMWJHd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklFSjVkR1Z6S0dJaVNHVnNiRzhpS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURRNE5qVTJZelpqTm1ZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG95TWkweU5Rb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkpUa2xVWDBKWlZFVlRDaUFnSUNBdkx5QnpaV3htTG1kc2IySmhiRjlpZVhSbGMxOW1kV3hzSUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnUW5sMFpYTW9ZaUpJWld4c2J5SXBDaUFnSUNBdkx5QXBJQ0FqSUVKNWRHVnpJSGRwZEdnZ1pHVm1ZWFZzZENCMllXeDFaU0E5SUdKNWRHVnpLRWhsYkd4dktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveU5nb2dJQ0FnTHk4Z2MyVnNaaTVuYkc5aVlXeGZZbmwwWlhOZmMybHRjR3hwWm1sbFpDQTlJRUo1ZEdWektBb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVoyeHZZbUZzWDJKNWRHVnpYM05wYlhCc2FXWnBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNall0TWpnS0lDQWdJQzh2SUhObGJHWXVaMnh2WW1Gc1gySjVkR1Z6WDNOcGJYQnNhV1pwWldRZ1BTQkNlWFJsY3lnS0lDQWdJQzh2SUNBZ0lDQmlJa2hsYkd4dklnb2dJQ0FnTHk4Z0tTQWdJeUJDZVhSbGN5QnphVzF3YkdsbWFXVmtJSGRwZEdnZ1pHVm1ZWFZzZENCMllXeDFaU0E5SUdKNWRHVnpLRWhsYkd4dktRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEUTROalUyWXpaak5tWUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklITmxiR1l1WjJ4dlltRnNYMkp2YjJ4ZmMybHRjR3hwWm1sbFpDQTlJRlJ5ZFdVZ0lDTWdRbTl2YkFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWjJ4dlltRnNYMkp2YjJ4ZmMybHRjR3hwWm1sbFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVE1LSUNBZ0lDOHZJR05zWVhOeklFZHNiMkpoYkZOMGIzSmhaMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU0Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdObE1UWmtNRGd6SURCNE9EbGxNbVV4TWpnZ01IaGpaalkyTlRnM09DQXdlR1EwT1RnMk9XUmhJREI0TldKaE5HWTBOamtnTUhnNE5qWmtORFE0TkNBd2VHSXhNR0l6T0RjeUlEQjRNMlpsWVdVek1HVWdNSGc0Wm1Rd05XUTFZU0F2THlCdFpYUm9iMlFnSW1kbGRGOW5iRzlpWVd4ZmMzUmhkR1VvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYldGNVltVmZaMnh2WW1Gc1gzTjBZWFJsS0Nrb2RXbHVkRFkwTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0puWlhSZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVW9LV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltMWhlV0psWDJkc2IySmhiRjl6ZEdGMFpWOWxlR0Z0Y0d4bEtDbGliMjlzSWl3Z2JXVjBhRzlrSUNKamFHVmphMTluYkc5aVlXeGZjM1JoZEdWZlpYaGhiWEJzWlNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpYzJWMFgyZHNiMkpoYkY5emRHRjBaU2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYMmRzYjJKaGJGOXpkR0YwWlY5bGVHRnRjR3hsS0dKNWRHVmJYU3gxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0prWld4ZloyeHZZbUZzWDNOMFlYUmxLQ2xpYjI5c0lpd2diV1YwYUc5a0lDSmtaV3hmWjJ4dlltRnNYM04wWVhSbFgyVjRZVzF3YkdVb0tXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCblpYUmZaMnh2WW1Gc1gzTjBZWFJsSUcxaGVXSmxYMmRzYjJKaGJGOXpkR0YwWlNCblpYUmZaMnh2WW1Gc1gzTjBZWFJsWDJWNFlXMXdiR1VnYldGNVltVmZaMnh2WW1Gc1gzTjBZWFJsWDJWNFlXMXdiR1VnWTJobFkydGZaMnh2WW1Gc1gzTjBZWFJsWDJWNFlXMXdiR1VnYzJWMFgyZHNiMkpoYkY5emRHRjBaU0J6WlhSZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVWdaR1ZzWDJkc2IySmhiRjl6ZEdGMFpTQmtaV3hmWjJ4dlltRnNYM04wWVhSbFgyVjRZVzF3YkdVS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhPRG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1SUM4dklHOXVJR1Z5Y205eU9pQlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bmJHOWlZV3hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVIYkc5aVlXeFRkRzl5WVdkbExtZGxkRjluYkc5aVlXeGZjM1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWjJ4dlltRnNYM04wWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkc2IySmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNW5iRzlpWVd4ZmFXNTBYMloxYkd3dVoyVjBLR1JsWm1GMWJIUTlWVWx1ZERZMEtEQXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHNiMkpoYkY5cGJuUmZablZzYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOREV0TkRJS0lDQWdJQzh2SUNNZ1pYaGhiWEJzWlRvZ1VrVkJSRjlIVEU5Q1FVeGZVMVJCVkVVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVoyeHZZbUZzWDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1UjJ4dlltRnNVM1J2Y21GblpTNXRZWGxpWlY5bmJHOWlZV3hmYzNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVhsaVpWOW5iRzlpWVd4ZmMzUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJR2x1ZEY5MllXeDFaU3dnYVc1MFgyVjRhWE4wY3lBOUlITmxiR1l1WjJ4dlltRnNYMmx1ZEY5bWRXeHNMbTFoZVdKbEtDa2dJQ01nZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVoyeHZZbUZzWDJsdWRGOW1kV3hzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJR2xtSUc1dmRDQnBiblJmWlhocGMzUnpPZ29nSUNBZ1ltNTZJRzFoZVdKbFgyZHNiMkpoYkY5emRHRjBaVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2FXNTBYM1poYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhDZ3B0WVhsaVpWOW5iRzlpWVd4ZmMzUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZHNiMkpoYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1kc2IySmhiRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa2RzYjJKaGJGTjBiM0poWjJVdVoyVjBYMmRzYjJKaGJGOXpkR0YwWlY5bGVHRnRjR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMmRzYjJKaGJGOXpkR0YwWlY5bGVHRnRjR3hsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bmJHOWlZV3hmYVc1MFgyWjFiR3d1WjJWMEtHUmxabUYxYkhROVZVbHVkRFkwS0RBcEtTQTlQU0ExTUNBZ0l5QjFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puYkc5aVlXeGZhVzUwWDJaMWJHd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYVc1MFkxOHpJQzh2SURVd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtZHNiMkpoYkY5cGJuUmZjMmx0Y0d4cFptbGxaQ0E5UFNCVlNXNTBOalFvTVRBcElDQWpJR2RsZENCbWRXNWpkR2x2YmlCallXNXViM1FnWW1VZ2RYTmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltZHNiMkpoYkY5cGJuUmZjMmx0Y0d4cFptbGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmJHOWlZV3hmYVc1MFgzTnBiWEJzYVdacFpXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8xTndvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVoyeHZZbUZzWDJsdWRGOXViMTlrWldaaGRXeDBMbWRsZENoa1pXWmhkV3gwUFZWSmJuUTJOQ2d3S1NrZ1BUMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSm5iRzlpWVd4ZmFXNTBYMjV2WDJSbFptRjFiSFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbWRzYjJKaGJGOWllWFJsYzE5bWRXeHNMbWRsZENoQ2VYUmxjeWhpSW1SbFptRjFiSFFpS1NrZ1BUMGdZaUpJWld4c2J5SWdJQ01nWW5sMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1kc2IySmhiRjlpZVhSbGMxOW1kV3hzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWTBOalUyTmpZeE56VTJZemMwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzBPRFkxTm1NMll6Wm1DaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW5iRzlpWVd4ZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1SGJHOWlZV3hUZEc5eVlXZGxMbTFoZVdKbFgyZHNiMkpoYkY5emRHRjBaVjlsZUdGdGNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldGNVltVmZaMnh2WW1Gc1gzTjBZWFJsWDJWNFlXMXdiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJR2x1ZEY5MllXeDFaU3dnYVY5bGVHbHpkSE1nUFNCelpXeG1MbWRzYjJKaGJGOXBiblJmWm5Wc2JDNXRZWGxpWlNncElDQWpJSFZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kc2IySmhiRjlwYm5SZlpuVnNiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUdGemMyVnlkQ0JwWDJWNGFYTjBjd29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBiblJmZG1Gc2RXVWdQVDBnVlVsdWREWTBLRFV3S1FvZ0lDQWdhVzUwWTE4eklDOHZJRFV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR0o1ZEdWZmRtRnNkV1VzSUdKZlpYaHBjM1J6SUQwZ2MyVnNaaTVuYkc5aVlXeGZZbmwwWlhOZlpuVnNiQzV0WVhsaVpTZ3BJQ0FqSUdKNWRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbmJHOWlZV3hmWW5sMFpYTmZablZzYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklHRnpjMlZ5ZENCaVgyVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnWVhOelpYSjBJR0o1ZEdWZmRtRnNkV1VnUFQwZ1lpSklaV3hzYnlJS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnME9EWTFObU0yWXpabUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1lsOWxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJpYjI5c1gzWmhiSFZsTENCcFgyVjRhWE4wY3lBOUlITmxiR1l1WjJ4dlltRnNYMkp2YjJ4ZmJtOWZaR1ZtWVhWc2RDNXRZWGxpWlNncElDQWpJR0p2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0puYkc5aVlXeGZZbTl2YkY5dWIxOWtaV1poZFd4MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5iRzlpWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdZWE56WlhKMElHbGZaWGhwYzNSekNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdKdmIyd29ZbTl2YkY5MllXeDFaU2tLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJoYzNObGRGOTJZV3gxWlN3Z2FWOWxlR2x6ZEhNZ1BTQnpaV3htTG1kc2IySmhiRjloYzNObGRDNXRZWGxpWlNncElDQWpJRUZ6YzJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWjJ4dlltRnNYMkZ6YzJWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5iRzlpWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdZWE56WlhKMElHbGZaWGhwYzNSekNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBYM1poYkhWbElEMDlJRUZ6YzJWMEtGVkpiblEyTkNneE1Da3BDaUFnSUNCcGJuUmpYeklnTHk4Z01UQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z1lYQndiRzVmZG1Gc2RXVXNJR2xmWlhocGMzUnpJRDBnYzJWc1ppNW5iRzlpWVd4ZllYQndiR2xqWVhScGIyNHViV0Y1WW1Vb0tTQWdJeUJCY0hCc2FXTmhkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0puYkc5aVlXeGZZWEJ3YkdsallYUnBiMjRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkc2IySmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCaGMzTmxjblFnYVY5bGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3Ykc1ZmRtRnNkV1VnUFQwZ1FYQndiR2xqWVhScGIyNG9WVWx1ZERZMEtERXdLU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZHNiMkpoYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTBMVFkxQ2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUZKRlFVUmZSMHhQUWtGTVgxTlVRVlJGWDBWWVFVMVFURVZUQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WjJ4dlltRnNYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1UzUnZjbUZuWlM1amFHVmphMTluYkc5aVlXeGZjM1JoZEdWZlpYaGhiWEJzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTm9aV05yWDJkc2IySmhiRjl6ZEdGMFpWOWxlR0Z0Y0d4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkc2IySmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNW5iRzlpWVd4ZmFXNTBYMloxYkd3dWRtRnNkV1VnUFQwZ05UQWdJQ01nZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVoyeHZZbUZzWDJsdWRGOW1kV3hzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHNiMkpoYkY5cGJuUmZablZzYkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTXlBdkx5QTFNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZHNiMkpoYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVuYkc5aVlXeGZZbmwwWlhOZlpuVnNiQzUyWVd4MVpTQTlQU0JDZVhSbGN5aGlJa2hsYkd4dklpa2dJQ01nWW5sMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1kc2IySmhiRjlpZVhSbGMxOW1kV3hzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHNiMkpoYkY5aWVYUmxjMTltZFd4c0lHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURRNE5qVTJZelpqTm1ZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtZHNiMkpoYkY5cGJuUmZjMmx0Y0d4cFptbGxaQ0E5UFNBeE1DQWdJeUIxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmJHOWlZV3hmYVc1MFgzTnBiWEJzYVdacFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjJ4dlltRnNYMmx1ZEY5emFXMXdiR2xtYVdWa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bmJHOWlZV3hmWW5sMFpYTmZjMmx0Y0d4cFptbGxaQ0E5UFNCaUlraGxiR3h2SWlBZ0l5QmllWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlaMnh2WW1Gc1gySjVkR1Z6WDNOcGJYQnNhV1pwWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMnh2WW1Gc1gySjVkR1Z6WDNOcGJYQnNhV1pwWldRZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TkRnMk5UWmpObU0yWmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnWVhOelpYSjBJR0p2YjJ3b2MyVnNaaTVuYkc5aVlXeGZZbTl2YkY5emFXMXdiR2xtYVdWa0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1kc2IySmhiRjlpYjI5c1gzTnBiWEJzYVdacFpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjJ4dlltRnNYMkp2YjJ4ZmMybHRjR3hwWm1sbFpDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkc2IySmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1kc2IySmhiRjlwYm5SZmJtOWZaR1ZtWVhWc2RBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKbmJHOWlZV3hmYVc1MFgyNXZYMlJsWm1GMWJIUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVuYkc5aVlXeGZZbmwwWlhOZmJtOWZaR1ZtWVhWc2RBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1kc2IySmhiRjlpZVhSbGMxOXViMTlrWldaaGRXeDBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBM0NpQWdJQ0F2THlCaGMzTmxjblFnYm05MElITmxiR1l1WjJ4dlltRnNYMkp2YjJ4ZmJtOWZaR1ZtWVhWc2RBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1kc2IySmhiRjlpYjI5c1gyNXZYMlJsWm1GMWJIUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtZHNiMkpoYkY5aGMzTmxkQzUyWVd4MVpTQTlQU0JCYzNObGRDaFZTVzUwTmpRb01UQXBLU0FnSXlCQmMzTmxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltZHNiMkpoYkY5aGMzTmxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmJHOWlZV3hmWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtZHNiMkpoYkY5aGNIQnNhV05oZEdsdmJpNTJZV3gxWlNBOVBTQkJjSEJzYVdOaGRHbHZiaWhWU1c1ME5qUW9NVEFwS1NBZ0l5QkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSm5iRzlpWVd4ZllYQndiR2xqWVhScGIyNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjJ4dlltRnNYMkZ3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklERXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVuYkc5aVlXeGZZV05qYjNWdWRDNTJZV3gxWlNBOVBTQkJZMk52ZFc1MEtFSjVkR1Z6S0dJaVNHVnNiRzhpS1NrZ0lDTWdRV05qYjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpWjJ4dlltRnNYMkZqWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjJ4dlltRnNYMkZqWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWE56WlhKMElDOHZJRUZrWkhKbGMzTWdiR1Z1WjNSb0lHbHpJRE15SUdKNWRHVnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRORGcyTlRaak5tTTJaZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZHNiMkpoYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qazFMVGsyQ2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUZaQlRGVkZYMUJTVDFCRlVsUlpYMGRNVDBKQlRGOVRWRUZVUlY5RldFRk5VRXhGVXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1kc2IySmhiRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa2RzYjJKaGJGTjBiM0poWjJVdWMyVjBYMmRzYjJKaGJGOXpkR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjluYkc5aVlXeGZjM1JoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXhOd29nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJYVWtsVVJWOUhURTlDUVV4ZlUxUkJWRVVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUhObGJHWXVaMnh2WW1Gc1gySjVkR1Z6WDJaMWJHd3VkbUZzZFdVZ1BTQjJZV3gxWlFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWjJ4dlltRnNYMko1ZEdWelgyWjFiR3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRzYjJKaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV4TmkweE1UY0tJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dWMUpKVkVWZlIweFBRa0ZNWDFOVVFWUkZDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaMnh2WW1Gc1gzTjBiM0poWjJVdVkyOXVkSEpoWTNRdVIyeHZZbUZzVTNSdmNtRm5aUzV6WlhSZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1USXpMVEV5TkFvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCWFVrbFVSVjlIVEU5Q1FVeGZVMVJCVkVWZlJWaEJUVkJNUlZNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklITmxiR1l1WjJ4dlltRnNYMko1ZEdWelgyNXZYMlJsWm1GMWJIUXVkbUZzZFdVZ1BTQjJZV3gxWlY5aWVYUmxjd29nSUNBZ1lubDBaV01nTnlBdkx5QWlaMnh2WW1Gc1gySjVkR1Z6WDI1dlgyUmxabUYxYkhRaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJ6Wld4bUxtZHNiMkpoYkY5aWIyOXNYMjV2WDJSbFptRjFiSFF1ZG1Gc2RXVWdQU0IyWVd4MVpWOWliMjlzSUNBaklFSnZiMndLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbWRzYjJKaGJGOWliMjlzWDI1dlgyUmxabUYxYkhRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmJHOWlZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHRnpjMlZ5ZENCaWIyOXNLSE5sYkdZdVoyeHZZbUZzWDJKdmIyeGZibTlmWkdWbVlYVnNkQzUyWVd4MVpTa0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZHNiMkpoYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXpPQW9nSUNBZ0x5OGdjMlZzWmk1bmJHOWlZV3hmWVhOelpYUXVkbUZzZFdVZ1BTQjJZV3gxWlY5aGMzTmxkQ0FnSXlCQmMzTmxkQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaMnh2WW1Gc1gyRnpjMlYwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYkc5aVlXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TWpNdE1USTBDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRmRTU1ZSRlgwZE1UMEpCVEY5VFZFRlVSVjlGV0VGTlVFeEZVd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWRzYjJKaGJGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrZHNiMkpoYkZOMGIzSmhaMlV1WkdWc1gyZHNiMkpoYkY5emRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJGOW5iRzlpWVd4ZmMzUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFEyQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVuYkc5aVlXeGZhVzUwWDJaMWJHd3VkbUZzZFdVS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kc2IySmhiRjlwYm5SZlpuVnNiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFF6TFRFME5Bb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkVSVXhGVkVWZlIweFBRa0ZNWDFOVVFWUkZDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaMnh2WW1Gc1gzTjBiM0poWjJVdVkyOXVkSEpoWTNRdVIyeHZZbUZzVTNSdmNtRm5aUzVrWld4ZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4ZloyeHZZbUZzWDNOMFlYUmxYMlY0WVcxd2JHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyeHZZbUZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNW5iRzlpWVd4ZllubDBaWE5mYm05ZlpHVm1ZWFZzZEM1MllXeDFaUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlaMnh2WW1Gc1gySjVkR1Z6WDI1dlgyUmxabUYxYkhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJSbGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkc2IySmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFMU5Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVoyeHZZbUZzWDJKdmIyeGZibTlmWkdWbVlYVnNkQzUyWVd4MVpRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVoyeHZZbUZzWDJKdmIyeGZibTlmWkdWbVlYVnNkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMnh2WW1Gc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFUyQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVuYkc5aVlXeGZZWE56WlhRdWRtRnNkV1VLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbWRzYjJKaGJGOWhjM05sZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWkdWc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJ4dlltRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRVeExURTFNZ29nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJFUlV4RlZFVmZSMHhQUWtGTVgxTlVRVlJGWDBWWVFVMVFURVZUQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUtNaVlORDJkc2IySmhiRjlwYm5SZlpuVnNiQVZJWld4c2J4Rm5iRzlpWVd4ZllubDBaWE5mWm5Wc2JBVVZIM3gxZ0JabmJHOWlZV3hmWW05dmJGOXViMTlrWldaaGRXeDBER2RzYjJKaGJGOWhjM05sZEJWbmJHOWlZV3hmYVc1MFgzTnBiWEJzYVdacFpXUVhaMnh2WW1Gc1gySjVkR1Z6WDI1dlgyUmxabUYxYkhRWFoyeHZZbUZzWDJKNWRHVnpYM05wYlhCc2FXWnBaV1FXWjJ4dlltRnNYMkp2YjJ4ZmMybHRjR3hwWm1sbFpBUVZIM3gxRldkc2IySmhiRjlwYm5SZmJtOWZaR1ZtWVhWc2RCSm5iRzlpWVd4ZllYQndiR2xqWVhScGIyNHhHRUFBRWlnbFp5Y0dKR2NxS1djbkNDbG5Kd2tqWnpFYlFRQk9NUmtVUkRFWVJJSUpCTTRXMElNRWllTGhLQVRQWmxoNEJOU1lhZG9FVzZUMGFRU0diVVNFQkxFTE9ISUVQK3JqRGdTUDBGMWFOaG9BamdrQUNRQVlBRFlBYUFDVUFQd0JCd0VuQVMwQU1Sa1VNUmdVRUVNaUtHVWlUZ0pORmljS1RGQ3dJME1pS0dWSlR3Sk1RQUFESWtVQlNSYUFBUUFpU3dSVVVDY0tURkN3STBNaUtHVWlUZ0pOSlJKRUlpY0daVVFrRWtRaUp3dGxJazRDVFJSRUlpcGxnQWRrWldaaGRXeDBUZ0pOS1JKRUs3QWpReUlvWlVRbEVrUWlLbVZKUkV3cEVrUVVSQ0luQkdWRVJDSW5CV1ZFSkJKRUlpY01aVVFrRWtRcnNDTkRJaWhsUkNVU1JDSXFaVVFwRWtRaUp3WmxSQ1FTUkNJbkNHVkVLUkpFSWljSlpVUkVJaWNMWlVVQkZFUWlKd2RsUlFFVVJDSW5CR1ZGQVJSRUlpY0ZaVVFrRWtRaUp3eGxSQ1FTUkNLQURtZHNiMkpoYkY5aFkyTnZkVzUwWlVRaVJDa1NSQ3V3STBNMkdnRlhBZ0FxVEdjalF6WWFBVmNDQURZYUFoYzJHZ01pVXljSFR3Tm5Kd1JMQVdkRUp3Vk1aeU5ES0drcnNDTkRKd2RwSndScEp3VnBLN0FqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
