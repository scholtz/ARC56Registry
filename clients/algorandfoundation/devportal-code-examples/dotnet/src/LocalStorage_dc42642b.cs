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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.LocalStorage_dc42642b
{


    public class LocalStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LocalStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MaybeLocalDataReturn : AVMObjectType
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

                public static MaybeLocalDataReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MaybeLocalDataReturn();
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
                    return Equals(obj as MaybeLocalDataReturn);
                }
                public bool Equals(MaybeLocalDataReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeLocalDataReturn left, MaybeLocalDataReturn right)
                {
                    return EqualityComparer<MaybeLocalDataReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeLocalDataReturn left, MaybeLocalDataReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> ContainsLocalData(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 13, 41, 107 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ContainsLocalData_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 13, 41, 107 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> ContainsLocalDataExample(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 51, 25, 146 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ContainsLocalDataExample_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 51, 25, 146 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<ulong> GetItemLocalData(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 183, 199, 46 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetItemLocalData_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 183, 199, 46 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<ulong> GetLocalDataWithDefaultInt(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 9, 174, 137 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLocalDataWithDefaultInt_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 9, 174, 137 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<Structs.MaybeLocalDataReturn> MaybeLocalData(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 184, 72, 56 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeLocalDataReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeLocalData_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 184, 72, 56 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> GetItemLocalDataExample(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 231, 143, 18 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetItemLocalDataExample_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 231, 143, 18 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> GetLocalDataWithDefault(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 23, 74, 227 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLocalDataWithDefault_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 23, 74, 227 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> MaybeLocalDataExample(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 232, 203, 230 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MaybeLocalDataExample_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 232, 203, 230 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        /// <param name="value"> </param>
        public async Task SetLocalInt(Algorand.Address for_account, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 157, 201, 243 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLocalInt_Transactions(Algorand.Address for_account, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 157, 201, 243 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        /// <param name="value_asset"> </param>
        /// <param name="value_account"> </param>
        /// <param name="value_appln"> </param>
        /// <param name="value_byte"> </param>
        /// <param name="value_bool"> </param>
        public async Task<bool> SetLocalDataExample(Algorand.Address for_account, ulong value_asset, Algorand.Address value_account, ulong value_appln, byte[] value_byte, bool value_bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 31, 215, 108 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);
            var value_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_assetAbi.From(value_asset);
            var value_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); value_accountAbi.From(value_account);
            var value_applnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_applnAbi.From(value_appln);
            var value_byteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_byteAbi.From(value_byte);
            var value_boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); value_boolAbi.From(value_bool);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi, value_assetAbi, value_accountAbi, value_applnAbi, value_byteAbi, value_boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetLocalDataExample_Transactions(Algorand.Address for_account, ulong value_asset, Algorand.Address value_account, ulong value_appln, byte[] value_byte, bool value_bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 31, 215, 108 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);
            var value_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_assetAbi.From(value_asset);
            var value_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); value_accountAbi.From(value_account);
            var value_applnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_applnAbi.From(value_appln);
            var value_byteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_byteAbi.From(value_byte);
            var value_boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); value_boolAbi.From(value_bool);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi, value_assetAbi, value_accountAbi, value_applnAbi, value_byteAbi, value_boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task DeleteLocalData(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 236, 212, 233 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteLocalData_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 236, 212, 233 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="for_account"> </param>
        public async Task<bool> DeleteLocalDataExample(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 211, 210, 85 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            var result = await base.CallApp(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeleteLocalDataExample_Transactions(Algorand.Address for_account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 211, 210, 85 };
            var for_accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); for_accountAbi.From(for_account);

            return await base.MakeTransactionList(new List<object> { abiHandle, for_accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9jYWxTdG9yYWdlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1heWJlTG9jYWxEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbnRhaW5zX2xvY2FsX2RhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnRhaW5zX2xvY2FsX2RhdGFfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9yX2FjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2l0ZW1fbG9jYWxfZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9yX2FjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbG9jYWxfZGF0YV93aXRoX2RlZmF1bHRfaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb3JfYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1heWJlX2xvY2FsX2RhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJNYXliZUxvY2FsRGF0YVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pdGVtX2xvY2FsX2RhdGFfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9yX2FjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2xvY2FsX2RhdGFfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb3JfYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXliZV9sb2NhbF9kYXRhX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9sb2NhbF9pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfbG9jYWxfZGF0YV9leGFtcGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb3JfYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZV9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZV9hcHBsbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfYnl0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlX2Jvb2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2xvY2FsX2RhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9sb2NhbF9kYXRhX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjQsImJ5dGVzIjoyfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDA4LDQ3OSw1NDZdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIGxlbmd0aCBpcyAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubG9jYWxfYWNjb3VudCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxvY2FsX2FwcGxpY2F0aW9uIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubG9jYWxfYXNzZXQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2NhbF9ib29sIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubG9jYWxfYnl0ZXMgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk4LDM2NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubG9jYWxfaW50IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMyw1MTEsNTIxLDUyOCw1MzcsNTQ0XSwiZXJyb3JNZXNzYWdlIjoibm8gZGF0YSBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTVRBS0lDQWdJR0o1ZEdWallteHZZMnNnSW14dlkyRnNYMmx1ZENJZ01IZ3hOVEZtTjJNM05UZ3dJQ0pzYjJOaGJGOWhZMk52ZFc1MElpQWliRzlqWVd4ZllubDBaWE1pSUNKc2IyTmhiRjlpYjI5c0lpQWliRzlqWVd4ZllYTnpaWFFpSUNKc2IyTmhiRjloY0hCc2FXTmhkR2x2YmlJZ01IZzBPRFkxTm1NMll6Wm1JREI0TVRVeFpqZGpOelVnTUhnME5EWTFOalkyTVRjMU5tTTNOREl3TlRZMk1UWmpOelUyTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVE1LSUNBZ0lDOHZJR05zWVhOeklFeHZZMkZzVTNSdmNtRm5aU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TlRjd1pESTVObUlnTUhnNU1qTXpNVGs1TWlBd2VESmhZamRqTnpKbElEQjROMll3T1dGbE9Ea2dNSGd3WldJNE5EZ3pPQ0F3ZURobFpUYzRaakV5SURCNFptVXhOelJoWlRNZ01IaGpaR1U0WTJKbE5pQXdlRGcxT1dSak9XWXpJREI0WmpZeFptUTNObU1nTUhnM04yVmpaRFJsT1NBd2VHRXpaRE5rTWpVMUlDOHZJRzFsZEdodlpDQWlZMjl1ZEdGcGJuTmZiRzlqWVd4ZlpHRjBZU2hoWkdSeVpYTnpLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltTnZiblJoYVc1elgyeHZZMkZzWDJSaGRHRmZaWGhoYlhCc1pTaGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOXBkR1Z0WDJ4dlkyRnNYMlJoZEdFb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXNiMk5oYkY5a1lYUmhYM2RwZEdoZlpHVm1ZWFZzZEY5cGJuUW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltMWhlV0psWDJ4dlkyRnNYMlJoZEdFb1lXUmtjbVZ6Y3lrb2RXbHVkRFkwTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0puWlhSZmFYUmxiVjlzYjJOaGJGOWtZWFJoWDJWNFlXMXdiR1VvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJmYkc5allXeGZaR0YwWVY5M2FYUm9YMlJsWm1GMWJIUW9ZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKdFlYbGlaVjlzYjJOaGJGOWtZWFJoWDJWNFlXMXdiR1VvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSnpaWFJmYkc5allXeGZhVzUwS0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjlzYjJOaGJGOWtZWFJoWDJWNFlXMXdiR1VvWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc1lubDBaVnRkTEdKdmIyd3BZbTl2YkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsWDJ4dlkyRnNYMlJoZEdFb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0prWld4bGRHVmZiRzlqWVd4ZlpHRjBZVjlsZUdGdGNHeGxLR0ZrWkhKbGMzTXBZbTl2YkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnZiblJoYVc1elgyeHZZMkZzWDJSaGRHRWdZMjl1ZEdGcGJuTmZiRzlqWVd4ZlpHRjBZVjlsZUdGdGNHeGxJR2RsZEY5cGRHVnRYMnh2WTJGc1gyUmhkR0VnWjJWMFgyeHZZMkZzWDJSaGRHRmZkMmwwYUY5a1pXWmhkV3gwWDJsdWRDQnRZWGxpWlY5c2IyTmhiRjlrWVhSaElHZGxkRjlwZEdWdFgyeHZZMkZzWDJSaGRHRmZaWGhoYlhCc1pTQm5aWFJmYkc5allXeGZaR0YwWVY5M2FYUm9YMlJsWm1GMWJIUWdiV0Y1WW1WZmJHOWpZV3hmWkdGMFlWOWxlR0Z0Y0d4bElITmxkRjlzYjJOaGJGOXBiblFnYzJWMFgyeHZZMkZzWDJSaGRHRmZaWGhoYlhCc1pTQmtaV3hsZEdWZmJHOWpZV3hmWkdGMFlTQmtaV3hsZEdWZmJHOWpZV3hmWkdGMFlWOWxlR0Z0Y0d4bENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJHOWpZV3hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVNYjJOaGJGTjBiM0poWjJVdVkyOXVkR0ZwYm5OZmJHOWpZV3hmWkdGMFlWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52Ym5SaGFXNXpYMnh2WTJGc1gyUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lOaTB5TndvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCRFQwNVVRVWxPWDFCU1QxQkZVbFJaWDB4UFEwRk1YMU5VUVZSRkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QmhjM05sY25RZ1ptOXlYMkZqWTI5MWJuUWdhVzRnYzJWc1ppNXNiMk5oYkY5cGJuUWdJQ01nVldsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJHOWpZV3hmYVc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakkyTFRJM0NpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFTlBUbFJCU1U1ZlVGSlBVRVZTVkZsZlRFOURRVXhmVTFSQlZFVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiMk5oYkY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGt4dlkyRnNVM1J2Y21GblpTNWpiMjUwWVdsdWMxOXNiMk5oYkY5a1lYUmhYMlY0WVcxd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjI1MFlXbHVjMTlzYjJOaGJGOWtZWFJoWDJWNFlXMXdiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3pOQzB6TlFvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCRFQwNVVRVWxPWDFCU1QxQkZVbFJaWDB4UFEwRk1YMU5VUVZSRlgwVllRVTFRVEVWVENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QmhjM05sY25RZ1ptOXlYMkZqWTI5MWJuUWdhVzRnYzJWc1ppNXNiMk5oYkY5cGJuUWdJQ01nVldsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2IyTmhiRjlwYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1iM0pmWVdOamIzVnVkQ0JwYmlCelpXeG1MbXh2WTJGc1gySjVkR1Z6SUNBaklFSjVkR1Z6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnNiMk5oYkY5aWVYUmxjeUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvek9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdadmNsOWhZMk52ZFc1MElHbHVJSE5sYkdZdWJHOWpZV3hmWW05dmJDQWdJeUJDYjI5c0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pzYjJOaGJGOWliMjlzSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmhjM05sY25RZ1ptOXlYMkZqWTI5MWJuUWdhVzRnYzJWc1ppNXNiMk5oYkY5aGMzTmxkQ0FnSXlCQmMzTmxkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJHOWpZV3hmWVhOelpYUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JtYjNKZllXTmpiM1Z1ZENCcGJpQnpaV3htTG14dlkyRnNYMkZ3Y0d4cFkyRjBhVzl1SUNBaklFRndjR3hwWTJGMGFXOXVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKc2IyTmhiRjloY0hCc2FXTmhkR2x2YmlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdZWE56WlhKMElHWnZjbDloWTJOdmRXNTBJR2x1SUhObGJHWXViRzlqWVd4ZllXTmpiM1Z1ZENBZ0l5QkJZMk52ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5allXeGZZV05qYjNWdWRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG96TkMwek5Rb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkRUMDVVUVVsT1gxQlNUMUJGVWxSWlgweFBRMEZNWDFOVVFWUkZYMFZZUVUxUVRFVlRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzlqWVd4ZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1TWIyTmhiRk4wYjNKaFoyVXVaMlYwWDJsMFpXMWZiRzlqWVd4ZlpHRjBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXBkR1Z0WDJ4dlkyRnNYMlJoZEdFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8wTnkwME9Bb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQlNSVUZFWDB4UFEwRk1YMU5VUVZSRkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVzYjJOaGJGOXBiblJiWm05eVgyRmpZMjkxYm5SZENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkc5allXeGZhVzUwSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHOWpZV3hmYVc1MElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRjdE5EZ0tJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dVa1ZCUkY5TVQwTkJURjlUVkVGVVJRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHZZMkZzWDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1VEc5allXeFRkRzl5WVdkbExtZGxkRjlzYjJOaGJGOWtZWFJoWDNkcGRHaGZaR1ZtWVhWc2RGOXBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZiRzlqWVd4ZlpHRjBZVjkzYVhSb1gyUmxabUYxYkhSZmFXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5USXROVE1LSUNBZ0lDOHZJQ01nWjJWMElHWjFibU4wYVc5dUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVzYjJOaGJGOXBiblF1WjJWMEtHWnZjbDloWTJOdmRXNTBMQ0JrWldaaGRXeDBQVlZKYm5RMk5DZ3dLU2tnSUNNZ1ZXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliRzlqWVd4ZmFXNTBJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TlRJdE5UTUtJQ0FnSUM4dklDTWdaMlYwSUdaMWJtTjBhVzl1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ykc5allXeGZjM1J2Y21GblpTNWpiMjUwY21GamRDNU1iMk5oYkZOMGIzSmhaMlV1YldGNVltVmZiRzlqWVd4ZlpHRjBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaGVXSmxYMnh2WTJGc1gyUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzFOeTAxT0FvZ0lDQWdMeThnSXlCdFlYbGlaU0JtZFc1amRHbHZiZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8yTUMwMk1Rb2dJQ0FnTHk4Z0l5QjFjMlZrSUhSdklHZGxkQ0JrWVhSaElHOXlJR0Z6YzJWeWRDQnBiblFLSUNBZ0lDOHZJSEpsYzNWc2RDd2daWGhwYzNSeklEMGdjMlZzWmk1c2IyTmhiRjlwYm5RdWJXRjVZbVVvWm05eVgyRmpZMjkxYm5RcElDQWpJRlZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW14dlkyRnNYMmx1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdhV1lnYm05MElHVjRhWE4wY3pvS0lDQWdJR0p1ZWlCdFlYbGlaVjlzYjJOaGJGOWtZWFJoWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklISmxjM1ZzZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01Rb0tiV0Y1WW1WZmJHOWpZV3hmWkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8xTnkwMU9Bb2dJQ0FnTHk4Z0l5QnRZWGxpWlNCbWRXNWpkR2x2YmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHZZMkZzWDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1VEc5allXeFRkRzl5WVdkbExtZGxkRjlwZEdWdFgyeHZZMkZzWDJSaGRHRmZaWGhoYlhCc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5cGRHVnRYMnh2WTJGc1gyUmhkR0ZmWlhoaGJYQnNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTRMVFk1Q2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUZKRlFVUmZURTlEUVV4ZlUxUkJWRVZmUlZoQlRWQk1SVk1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJsdWRGdG1iM0pmWVdOamIzVnVkRjBnUFQwZ1ZVbHVkRFkwS0FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliRzlqWVd4ZmFXNTBJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ykc5allXeGZhVzUwSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOekV0TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJsdWRGdG1iM0pmWVdOamIzVnVkRjBnUFQwZ1ZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lERXdDaUFnSUNBdkx5QXBJQ0FqSUZWcGJuUTJOQ0F0SUhKbGRIVnlibk1nWjNWeVlXNTBaV1ZrSUdSaGRHRUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJKNWRHVnpXMlp2Y2w5aFkyTnZkVzUwWFNBOVBTQmlJa2hsYkd4dklpQWdJeUJDZVhSbGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYkc5allXeGZZbmwwWlhNaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNiMk5oYkY5aWVYUmxjeUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGcwT0RZMU5tTTJZelptQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdZWE56WlhKMElHSnZiMndvYzJWc1ppNXNiMk5oYkY5aWIyOXNXMlp2Y2w5aFkyTnZkVzUwWFNrZ0lDTWdRbTl2YkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqWVd4ZlltOXZiQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14dlkyRnNYMkp2YjJ3Z1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pjMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXNiMk5oYkY5aGMzTmxkRnRtYjNKZllXTmpiM1Z1ZEYwZ1BUMGdRWE56WlhRb1ZVbHVkRFkwS0RFd0tTa2dJQ01nUVhOelpYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14dlkyRnNYMkZ6YzJWMElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViRzlqWVd4ZllYTnpaWFFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVzYjJOaGJGOWhjSEJzYVdOaGRHbHZibHRtYjNKZllXTmpiM1Z1ZEYwZ1BUMGdRWEJ3YkdsallYUnBiMjRvQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNiMk5oYkY5aGNIQnNhV05oZEdsdmJpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXh2WTJGc1gyRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklGVkpiblEyTkNneE1Da0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpjdE56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbXh2WTJGc1gyRndjR3hwWTJGMGFXOXVXMlp2Y2w5aFkyTnZkVzUwWFNBOVBTQkJjSEJzYVdOaGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvTVRBcENpQWdJQ0F2THlBcElDQWpJRUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Ykc5allXeGZZV05qYjNWdWRGdG1iM0pmWVdOamIzVnVkRjBnUFQwZ1FXTmpiM1Z1ZENoQ2VYUmxjeWhpSWtobGJHeHZJaWtwSUNBaklFRmpZMjkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzYjJOaGJGOWhZMk52ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViRzlqWVd4ZllXTmpiM1Z1ZENCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzBPRFkxTm1NMll6Wm1DaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvMk9DMDJPUW9nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJTUlVGRVgweFBRMEZNWDFOVVFWUkZYMFZZUVUxUVRFVlRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzlqWVd4ZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1TWIyTmhiRk4wYjNKaFoyVXVaMlYwWDJ4dlkyRnNYMlJoZEdGZmQybDBhRjlrWldaaGRXeDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyeHZZMkZzWDJSaGRHRmZkMmwwYUY5a1pXWmhkV3gwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJsdWRDNW5aWFFvWm05eVgyRmpZMjkxYm5Rc0lHUmxabUYxYkhROVZVbHVkRFkwS0RBcEtTQTlQU0JWU1c1ME5qUW9DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2IyTmhiRjlwYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzROUzA0TndvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWJHOWpZV3hmYVc1MExtZGxkQ2htYjNKZllXTmpiM1Z1ZEN3Z1pHVm1ZWFZzZEQxVlNXNTBOalFvTUNrcElEMDlJRlZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0F4TUFvZ0lDQWdMeThnS1NBZ0l5QlZhVzUwTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPRGd0T1RBS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJKNWRHVnpMbWRsZENnS0lDQWdJQzh2SUNBZ0lDQm1iM0pmWVdOamIzVnVkQ3dnWkdWbVlYVnNkRDFDZVhSbGN5aGlJa1JsWm1GMWJIUWdWbUZzZFdVaUtRb2dJQ0FnTHk4Z0tTQTlQU0JDZVhSbGN5Z0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1c2IyTmhiRjlpZVhSbGN5NW5aWFFvQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzYjJOaGJGOWllWFJsY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamc0TFRrd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXNiMk5oYkY5aWVYUmxjeTVuWlhRb0NpQWdJQ0F2THlBZ0lDQWdabTl5WDJGalkyOTFiblFzSUdSbFptRjFiSFE5UW5sMFpYTW9ZaUpFWldaaGRXeDBJRlpoYkhWbElpa0tJQ0FnSUM4dklDa2dQVDBnUW5sMFpYTW9DaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdabTl5WDJGalkyOTFiblFzSUdSbFptRjFiSFE5UW5sMFpYTW9ZaUpFWldaaGRXeDBJRlpoYkhWbElpa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzBORFkxTmpZMk1UYzFObU0zTkRJd05UWTJNVFpqTnpVMk5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RndE9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbXh2WTJGc1gySjVkR1Z6TG1kbGRDZ0tJQ0FnSUM4dklDQWdJQ0JtYjNKZllXTmpiM1Z1ZEN3Z1pHVm1ZWFZzZEQxQ2VYUmxjeWhpSWtSbFptRjFiSFFnVm1Gc2RXVWlLUW9nSUNBZ0x5OGdLU0E5UFNCQ2VYUmxjeWdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T1RBdE9USUtJQ0FnSUM4dklDa2dQVDBnUW5sMFpYTW9DaUFnSUNBdkx5QWdJQ0FnWWlKSVpXeHNieUlLSUNBZ0lDOHZJQ2tnSUNNZ1FubDBaWE1LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGcwT0RZMU5tTTJZelptQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzRPQzA1TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWJHOWpZV3hmWW5sMFpYTXVaMlYwS0FvZ0lDQWdMeThnSUNBZ0lHWnZjbDloWTJOdmRXNTBMQ0JrWldaaGRXeDBQVUo1ZEdWektHSWlSR1ZtWVhWc2RDQldZV3gxWlNJcENpQWdJQ0F2THlBcElEMDlJRUo1ZEdWektBb2dJQ0FnTHk4Z0lDQWdJR0lpU0dWc2JHOGlDaUFnSUNBdkx5QXBJQ0FqSUVKNWRHVnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdKdmIyd29jMlZzWmk1c2IyTmhiRjlpYjI5c0xtZGxkQ2htYjNKZllXTmpiM1Z1ZEN3Z1pHVm1ZWFZzZEQxR1lXeHpaU2twSUNBaklFSnZiMndLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lteHZZMkZzWDJKdmIyd2lDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXNiMk5oYkY5aGMzTmxkQzVuWlhRb1ptOXlYMkZqWTI5MWJuUXNJR1JsWm1GMWJIUTlRWE56WlhRb1ZVbHVkRFkwS0RBcEtTa2dQVDBnUVhOelpYUW9DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKc2IyTmhiRjloYzNObGRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJWU1c1ME5qUW9NVEFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qazFMVGszQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1c2IyTmhiRjloYzNObGRDNW5aWFFvWm05eVgyRmpZMjkxYm5Rc0lHUmxabUYxYkhROVFYTnpaWFFvVlVsdWREWTBLREFwS1NrZ1BUMGdRWE56WlhRb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtERXdLUW9nSUNBZ0x5OGdLU0FnSXlCQmMzTmxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk9UZ3RNVEF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1c2IyTmhiRjloY0hCc2FXTmhkR2x2Ymk1blpYUW9DaUFnSUNBdkx5QWdJQ0FnWm05eVgyRmpZMjkxYm5Rc0lHUmxabUYxYkhROVFYQndiR2xqWVhScGIyNG9WVWx1ZERZMEtEQXBLUW9nSUNBZ0x5OGdLU0E5UFNCQmNIQnNhV05oZEdsdmJpZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1c2IyTmhiRjloY0hCc2FXTmhkR2x2Ymk1blpYUW9DaUFnSUNCaWVYUmxZeUEySUM4dklDSnNiMk5oYkY5aGNIQnNhV05oZEdsdmJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2prNExURXdNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Ykc5allXeGZZWEJ3YkdsallYUnBiMjR1WjJWMEtBb2dJQ0FnTHk4Z0lDQWdJR1p2Y2w5aFkyTnZkVzUwTENCa1pXWmhkV3gwUFVGd2NHeHBZMkYwYVc5dUtGVkpiblEyTkNnd0tTa0tJQ0FnSUM4dklDa2dQVDBnUVhCd2JHbGpZWFJwYjI0b0NpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1ptOXlYMkZqWTI5MWJuUXNJR1JsWm1GMWJIUTlRWEJ3YkdsallYUnBiMjRvVlVsdWREWTBLREFwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qazRMVEV3TUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWJHOWpZV3hmWVhCd2JHbGpZWFJwYjI0dVoyVjBLQW9nSUNBZ0x5OGdJQ0FnSUdadmNsOWhZMk52ZFc1MExDQmtaV1poZFd4MFBVRndjR3hwWTJGMGFXOXVLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lDOHZJQ2tnUFQwZ1FYQndiR2xqWVhScGIyNG9DaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnVlVsdWREWTBLREV3S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzVPQzB4TURJS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJGd2NHeHBZMkYwYVc5dUxtZGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCbWIzSmZZV05qYjNWdWRDd2daR1ZtWVhWc2REMUJjSEJzYVdOaGRHbHZiaWhWU1c1ME5qUW9NQ2twQ2lBZ0lDQXZMeUFwSUQwOUlFRndjR3hwWTJGMGFXOXVLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2d4TUNrS0lDQWdJQzh2SUNrZ0lDTWdRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdabTl5WDJGalkyOTFiblFzSUdSbFptRjFiSFE5UVdOamIzVnVkQ2hDZVhSbGN5aGlJa1JsWm1GMWJIUWdWbUZzZFdVaUtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoYzNObGNuUWdMeThnUVdSa2NtVnpjeUJzWlc1bmRHZ2dhWE1nTXpJZ1lubDBaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXdNeTB4TURVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxteHZZMkZzWDJGalkyOTFiblF1WjJWMEtBb2dJQ0FnTHk4Z0lDQWdJR1p2Y2w5aFkyTnZkVzUwTENCa1pXWmhkV3gwUFVGalkyOTFiblFvUW5sMFpYTW9ZaUpFWldaaGRXeDBJRlpoYkhWbElpa3BDaUFnSUNBdkx5QXBJRDA5SUVGalkyOTFiblFvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVzYjJOaGJGOWhZMk52ZFc1MExtZGxkQ2dLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXh2WTJGc1gyRmpZMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURNdE1UQTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVzYjJOaGJGOWhZMk52ZFc1MExtZGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCbWIzSmZZV05qYjNWdWRDd2daR1ZtWVhWc2REMUJZMk52ZFc1MEtFSjVkR1Z6S0dJaVJHVm1ZWFZzZENCV1lXeDFaU0lwS1FvZ0lDQWdMeThnS1NBOVBTQkJZMk52ZFc1MEtBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5Qm1iM0pmWVdOamIzVnVkQ3dnWkdWbVlYVnNkRDFCWTJOdmRXNTBLRUo1ZEdWektHSWlSR1ZtWVhWc2RDQldZV3gxWlNJcEtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEUTBOalUyTmpZeE56VTJZemMwTWpBMU5qWXhObU0zTlRZMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURNdE1UQTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVzYjJOaGJGOWhZMk52ZFc1MExtZGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCbWIzSmZZV05qYjNWdWRDd2daR1ZtWVhWc2REMUJZMk52ZFc1MEtFSjVkR1Z6S0dJaVJHVm1ZWFZzZENCV1lXeDFaU0lwS1FvZ0lDQWdMeThnS1NBOVBTQkJZMk52ZFc1MEtBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJRUo1ZEdWektHSWlTR1ZzYkc4aUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEUTROalUyWXpaak5tWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd015MHhNRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG14dlkyRnNYMkZqWTI5MWJuUXVaMlYwS0FvZ0lDQWdMeThnSUNBZ0lHWnZjbDloWTJOdmRXNTBMQ0JrWldaaGRXeDBQVUZqWTI5MWJuUW9RbmwwWlhNb1lpSkVaV1poZFd4MElGWmhiSFZsSWlrcENpQWdJQ0F2THlBcElEMDlJRUZqWTI5MWJuUW9DaUFnSUNBdkx5QWdJQ0FnUW5sMFpYTW9ZaUpJWld4c2J5SXBDaUFnSUNBdkx5QXBJQ0FqSUVGalkyOTFiblFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzlqWVd4ZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1TWIyTmhiRk4wYjNKaFoyVXViV0Y1WW1WZmJHOWpZV3hmWkdGMFlWOWxlR0Z0Y0d4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV0Y1WW1WZmJHOWpZV3hmWkdGMFlWOWxlR0Z0Y0d4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdjbVZ6ZFd4MExDQmxlR2x6ZEhNZ1BTQnpaV3htTG14dlkyRnNYMmx1ZEM1dFlYbGlaU2htYjNKZllXTmpiM1Z1ZENrZ0lDTWdWV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzYjJOaGJGOXBiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0p1YnlCa1lYUmhJR1p2Y2lCaFkyTnZkVzUwSWdvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUdSaGRHRWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZWE56WlhKMElISmxjM1ZzZENBOVBTQlZTVzUwTmpRb01UQXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z2NtVnpkV3gwWDJKNWRHVnpMQ0JsZUdsemRITWdQU0J6Wld4bUxteHZZMkZzWDJKNWRHVnpMbTFoZVdKbEtHWnZjbDloWTJOdmRXNTBLU0FnSXlCQ2VYUmxjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJHOWpZV3hmWW5sMFpYTWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSnVieUJrWVhSaElHWnZjaUJoWTJOdmRXNTBJZ29nSUNBZ1lYTnpaWEowSUM4dklHNXZJR1JoZEdFZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMzVnNkRjlpZVhSbGN5QTlQU0JpSWtobGJHeHZJZ29nSUNBZ1lubDBaV01nTnlBdkx5QXdlRFE0TmpVMll6WmpObVlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdjbVZ6ZFd4MFgySnZiMndzSUdWNGFYTjBjeUE5SUhObGJHWXViRzlqWVd4ZlltOXZiQzV0WVhsaVpTaG1iM0pmWVdOamIzVnVkQ2tnSUNNZ1FtOXZiQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJHOWpZV3hmWW05dmJDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3l3Z0ltNXZJR1JoZEdFZ1ptOXlJR0ZqWTI5MWJuUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdaR0YwWVNCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCaGMzTmxjblFnWW05dmJDaHlaWE4xYkhSZlltOXZiQ2tLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJ5WlhOMWJIUmZZWE56WlhRc0lHVjRhWE4wY3lBOUlITmxiR1l1Ykc5allXeGZZWE56WlhRdWJXRjVZbVVvWm05eVgyRmpZMjkxYm5RcElDQWpJRUZ6YzJWMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzYjJOaGJGOWhjM05sZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeXdnSW01dklHUmhkR0VnWm05eUlHRmpZMjkxYm5RaUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1pHRjBZU0JtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ6ZFd4MFgyRnpjMlYwSUQwOUlFRnpjMlYwS0ZWSmJuUTJOQ2d4TUNrcENpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnY21WemRXeDBYMkZ3Y0d4dUxDQmxlR2x6ZEhNZ1BTQnpaV3htTG14dlkyRnNYMkZ3Y0d4cFkyRjBhVzl1TG0xaGVXSmxLR1p2Y2w5aFkyTnZkVzUwS1NBZ0l5QkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJHOWpZV3hmWVhCd2JHbGpZWFJwYjI0aUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKdWJ5QmtZWFJoSUdadmNpQmhZMk52ZFc1MElnb2dJQ0FnWVhOelpYSjBJQzh2SUc1dklHUmhkR0VnWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnWVhOelpYSjBJSEpsYzNWc2RGOWhjSEJzYmlBOVBTQkJjSEJzYVdOaGRHbHZiaWhWU1c1ME5qUW9NVEFwS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJSEpsYzNWc2RGOWhZMk52ZFc1MExDQmxlR2x6ZEhNZ1BTQnpaV3htTG14dlkyRnNYMkZqWTI5MWJuUXViV0Y1WW1Vb1ptOXlYMkZqWTI5MWJuUXBJQ0FqSUVGalkyOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnNiMk5oYkY5aFkyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpYm04Z1pHRjBZU0JtYjNJZ1lXTmpiM1Z1ZENJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YnlCa1lYUmhJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWE4xYkhSZllXTmpiM1Z1ZENBOVBTQkJZMk52ZFc1MEtFSjVkR1Z6S0dJaVNHVnNiRzhpS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzBPRFkxTm1NMll6Wm1DaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiMk5oYkY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGt4dlkyRnNVM1J2Y21GblpTNXpaWFJmYkc5allXeGZhVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMnh2WTJGc1gybHVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTBNQzB4TkRFS0lDQWdJQzh2SUNNZ1pYaGhiWEJzWlRvZ1YxSkpWRVZmVEU5RFFVeGZVMVJCVkVVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QnpaV3htTG14dlkyRnNYMmx1ZEZ0bWIzSmZZV05qYjNWdWRGMGdQU0IyWVd4MVpTQWdJeUJWYVc1ME5qUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHZZMkZzWDJsdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFME1DMHhOREVLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nVjFKSlZFVmZURTlEUVV4ZlUxUkJWRVVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVzYjJOaGJGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExreHZZMkZzVTNSdmNtRm5aUzV6WlhSZmJHOWpZV3hmWkdGMFlWOWxlR0Z0Y0d4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDJ4dlkyRnNYMlJoZEdGZlpYaGhiWEJzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUwTnkweE5EZ0tJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dWMUpKVkVWZlRFOURRVXhmVTFSQlZFVmZSVmhCVFZCTVJWTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMk5oYkY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTFPUW9nSUNBZ0x5OGdjMlZzWmk1c2IyTmhiRjlpZVhSbGMxdG1iM0pmWVdOamIzVnVkRjBnUFNCMllXeDFaVjlpZVhSbElDQWpJRUo1ZEdWekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJHOWpZV3hmWW5sMFpYTWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUyTWdvZ0lDQWdMeThnYzJWc1ppNXNiMk5oYkY5aWIyOXNXMlp2Y2w5aFkyTnZkVzUwWFNBOUlIWmhiSFZsWDJKdmIyd2dJQ01nUW05dmJBb2dJQ0FnWkdsbklEUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lteHZZMkZzWDJKdmIyd2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUyTlFvZ0lDQWdMeThnYzJWc1ppNXNiMk5oYkY5aGMzTmxkRnRtYjNKZllXTmpiM1Z1ZEYwZ1BTQjJZV3gxWlY5aGMzTmxkQ0FnSXlCQmMzTmxkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbXh2WTJGc1gyRnpjMlYwSWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWpZV3hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklITmxiR1l1Ykc5allXeGZZWEJ3YkdsallYUnBiMjViWm05eVgyRmpZMjkxYm5SZElEMGdkbUZzZFdWZllYQndiRzRnSUNNZ1FYQndiR2xqWVhScGIyNEtJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNiMk5oYkY5aGNIQnNhV05oZEdsdmJpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVGN4Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzWDJGalkyOTFiblJiWm05eVgyRmpZMjkxYm5SZElEMGdkbUZzZFdWZllXTmpiM1Z1ZENBZ0l5QkJZMk52ZFc1MENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc2IyTmhiRjloWTJOdmRXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UUTNMVEUwT0FvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCWFVrbFVSVjlNVDBOQlRGOVRWRUZVUlY5RldFRk5VRXhGVXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14dlkyRnNYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVURzlqWVd4VGRHOXlZV2RsTG1SbGJHVjBaVjlzYjJOaGJGOWtZWFJoVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsWDJ4dlkyRnNYMlJoZEdFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TnpjdE1UYzRDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRVJGVEVWVVJWOU1UME5CVEY5VFZFRlVSUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5allXeGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUdSbGJDQnpaV3htTG14dlkyRnNYMkZqWTI5MWJuUmJabTl5WDJGalkyOTFiblJkSUNBaklGVnBiblEyTkFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5allXeGZZV05qYjNWdWRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFM055MHhOemdLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nUkVWTVJWUkZYMHhQUTBGTVgxTlVRVlJGQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ykc5allXeGZjM1J2Y21GblpTNWpiMjUwY21GamRDNU1iMk5oYkZOMGIzSmhaMlV1WkdWc1pYUmxYMnh2WTJGc1gyUmhkR0ZmWlhoaGJYQnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJHVjBaVjlzYjJOaGJGOWtZWFJoWDJWNFlXMXdiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hPRFF0TVRnMUNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFUkZURVZVUlY5TVQwTkJURjlUVkVGVVJWOUZXRUZOVUV4RlV3b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hPRGNLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbXh2WTJGc1gybHVkRnRtYjNKZllXTmpiM1Z1ZEYwZ0lDTWdWV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW14dlkyRnNYMmx1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjlrWld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJOaGJGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakU0T0FvZ0lDQWdMeThnWkdWc0lITmxiR1l1Ykc5allXeGZZbmwwWlhOYlptOXlYMkZqWTI5MWJuUmRJQ0FqSUVKNWRHVnpDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lteHZZMkZzWDJKNWRHVnpJZ29nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZMkZzWDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXNiMk5oYkY5aWIyOXNXMlp2Y2w5aFkyTnZkVzUwWFNBZ0l5QkNiMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WTJGc1gySnZiMndpQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzlqWVd4ZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hPVEFLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbXh2WTJGc1gyRnpjMlYwVzJadmNsOWhZMk52ZFc1MFhTQWdJeUJCYzNObGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKc2IyTmhiRjloYzNObGRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyTmhiRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFNU1Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdWJHOWpZV3hmWVhCd2JHbGpZWFJwYjI1YlptOXlYMkZqWTI5MWJuUmRJQ0FqSUVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW14dlkyRnNYMkZ3Y0d4cFkyRjBhVzl1SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMlJsYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WTJGc1gzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVGt5Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVzYjJOaGJGOWhZMk52ZFc1MFcyWnZjbDloWTJOdmRXNTBYU0FnSXlCQlkyTnZkVzUwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzYjJOaGJGOWhZMk52ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJSbGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dlkyRnNYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRnMExURTROUW9nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJFUlV4RlZFVmZURTlEUVV4ZlUxUkJWRVZmUlZoQlRWQk1SVk1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUtKZ29KYkc5allXeGZhVzUwQlJVZmZIV0FEV3h2WTJGc1gyRmpZMjkxYm5RTGJHOWpZV3hmWW5sMFpYTUtiRzlqWVd4ZlltOXZiQXRzYjJOaGJGOWhjM05sZEJGc2IyTmhiRjloY0hCc2FXTmhkR2x2YmdWSVpXeHNid1FWSDN4MURVUmxabUYxYkhRZ1ZtRnNkV1V4RzBFQVl6RVpGRVF4R0VTQ0RBUlhEU2xyQkpJekdaSUVLcmZITGdSL0NhNkpCQTY0U0RnRWp1ZVBFZ1QrRjByakJNM295K1lFaFozSjh3VDJIOWRzQkhmczFPa0VvOVBTVlRZYUFJNE1BQWtBRmdCSkFGZ0FhZ0NMQU1ZQkZRRlFBVndCbHdHZUFERVpGREVZRkJCRE5ob0JJaWhqUlFGRUtiQWpRellhQVVraUtHTkZBVVJKSWl0alJRRkVTU0luQkdORkFVUkpJaWNGWTBVQlJFa2lKd1pqUlFGRUlpcGpSUUZFS2JBalF6WWFBU0lvWTBRV0p3aE1VTEFqUXpZYUFTSW9ZeUpPQWswV0p3aE1VTEFqUXpZYUFTSW9ZMGxQQWt4QUFBTWlSUUZKRm9BQkFDSkxCRlJRSndoTVVMQWpRellhQVVraUtHTkVKQkpFU1NJclkwUW5CeEpFU1NJbkJHTkVSRWtpSndWalJDUVNSRWtpSndaalJDUVNSQ0lxWTBRaVJDY0hFa1Fwc0NORE5ob0JTU0lvWXlKT0FrMGtFa1JKSWl0akp3bE9BazBuQnhKRVNTSW5CR01pVGdKTlJFa2lKd1ZqSWs0Q1RTUVNSRWtpSndaaklrNENUU1FTUkNKRUlpcGpKd2xPQWswbkJ4SkVLYkFqUXpZYUFVa2lLR05FSkJKRVNTSXJZMFFuQnhKRVNTSW5CR05FUkVraUp3VmpSQ1FTUkVraUp3WmpSQ1FTUkNJcVkwUWlSQ2NIRWtRcHNDTkROaG9CTmhvQ0Z5aE1aaU5ETmhvQk5ob0NGellhQXpZYUJCYzJHZ1ZYQWdBMkdnWWlVMHNGSzA4RFprc0VKd1JQQW1aTEF5Y0ZUd1JtU3dJbkJrOENaaXBNWmltd0kwTTJHZ0VxYUNORE5ob0JTU2hvU1N0b1NTY0VhRWtuQldoSkp3Wm9LbWdwc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
