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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAppBox_fcd3701e
{


    //
    // A contract that uses box storage to maintain a counter for each account
    //Each account needs to pay for the Minimum Balance Requirement (MBR) for their box
    //Constants for box storage are stored in global state
    //
    public class ReferenceAppBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAppBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetBoxConfigurationReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetBoxConfigurationReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBoxConfigurationReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBoxConfigurationReturn);
                }
                public bool Equals(GetBoxConfigurationReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBoxConfigurationReturn left, GetBoxConfigurationReturn right)
                {
                    return EqualityComparer<GetBoxConfigurationReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBoxConfigurationReturn left, GetBoxConfigurationReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Increments the counter for the transaction sender
        ///Requires a payment transaction to cover the MBR for the box
        ///</summary>
        /// <param name="payMbr">Payment transaction covering the box MBR </param>
        public async Task<ulong> IncrementBoxCounter(PaymentTransaction payMbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payMbr });
            byte[] abiHandle = { 4, 10, 35, 94 };

            var result = await base.SimApp(new List<object> { abiHandle, payMbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementBoxCounter_Transactions(PaymentTransaction payMbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payMbr });
            byte[] abiHandle = { 4, 10, 35, 94 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payMbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Gets the current counter value for the transaction sender
        ///</summary>
        public async Task<ulong> GetBoxCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 161, 69 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBoxCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 161, 69 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Gets the current counter value for any account
        ///</summary>
        /// <param name="account">The account to check </param>
        public async Task<ulong> GetBoxCounterForAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 36, 229, 224 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBoxCounterForAccount_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 36, 229, 224 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the MBR cost for creating a box
        ///</summary>
        public async Task<ulong> GetBoxMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 181, 35, 158 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBoxMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 181, 35, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns all the box size configuration values
        ///</summary>
        public async Task<Structs.GetBoxConfigurationReturn> GetBoxConfiguration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 239, 231, 245 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBoxConfigurationReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoxConfiguration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 239, 231, 245 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Updates the box size configuration values
        ///</summary>
        /// <param name="newKeyLength">The new key length </param>
        /// <param name="newValueLength">The new value length </param>
        public async Task UpdateBoxConfiguration(ulong newKeyLength, ulong newValueLength, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 56, 81, 98 };
            var newKeyLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newKeyLengthAbi.From(newKeyLength);
            var newValueLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newValueLengthAbi.From(newValueLength);

            var result = await base.SimApp(new List<object> { abiHandle, newKeyLengthAbi, newValueLengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBoxConfiguration_Transactions(ulong newKeyLength, ulong newValueLength, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 56, 81, 98 };
            var newKeyLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newKeyLengthAbi.From(newKeyLength);
            var newValueLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newValueLengthAbi.From(newValueLength);

            return await base.MakeTransactionList(new List<object> { abiHandle, newKeyLengthAbi, newValueLengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQXBwQm94IiwiZGVzYyI6IkEgY29udHJhY3QgdGhhdCB1c2VzIGJveCBzdG9yYWdlIHRvIG1haW50YWluIGEgY291bnRlciBmb3IgZWFjaCBhY2NvdW50XG5FYWNoIGFjY291bnQgbmVlZHMgdG8gcGF5IGZvciB0aGUgTWluaW11bSBCYWxhbmNlIFJlcXVpcmVtZW50IChNQlIpIGZvciB0aGVpciBib3hcbkNvbnN0YW50cyBmb3IgYm94IHN0b3JhZ2UgYXJlIHN0b3JlZCBpbiBnbG9iYWwgc3RhdGUiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0Qm94Q29uZmlndXJhdGlvblJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5jcmVtZW50Qm94Q291bnRlciIsImRlc2MiOiJJbmNyZW1lbnRzIHRoZSBjb3VudGVyIGZvciB0aGUgdHJhbnNhY3Rpb24gc2VuZGVyXG5SZXF1aXJlcyBhIHBheW1lbnQgdHJhbnNhY3Rpb24gdG8gY292ZXIgdGhlIE1CUiBmb3IgdGhlIGJveCIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlNYnIiLCJkZXNjIjoiUGF5bWVudCB0cmFuc2FjdGlvbiBjb3ZlcmluZyB0aGUgYm94IE1CUiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgbmV3IGNvdW50ZXIgdmFsdWUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEJveENvdW50ZXIiLCJkZXNjIjoiR2V0cyB0aGUgY3VycmVudCBjb3VudGVyIHZhbHVlIGZvciB0aGUgdHJhbnNhY3Rpb24gc2VuZGVyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBjdXJyZW50IGNvdW50ZXIgdmFsdWUgb3IgMCBpZiBub3Qgc2V0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCb3hDb3VudGVyRm9yQWNjb3VudCIsImRlc2MiOiJHZXRzIHRoZSBjdXJyZW50IGNvdW50ZXIgdmFsdWUgZm9yIGFueSBhY2NvdW50IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6IlRoZSBhY2NvdW50IHRvIGNoZWNrIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBjdXJyZW50IGNvdW50ZXIgdmFsdWUgb3IgMCBpZiBub3Qgc2V0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCb3hNYnIiLCJkZXNjIjoiUmV0dXJucyB0aGUgTUJSIGNvc3QgZm9yIGNyZWF0aW5nIGEgYm94IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBNQlIgY29zdCBpbiBtaWNyb0FsZ29zIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCb3hDb25maWd1cmF0aW9uIiwiZGVzYyI6IlJldHVybnMgYWxsIHRoZSBib3ggc2l6ZSBjb25maWd1cmF0aW9uIHZhbHVlcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldEJveENvbmZpZ3VyYXRpb25SZXR1cm4iLCJkZXNjIjoiQSB0dXBsZSBjb250YWluaW5nIFtrZXlMZW5ndGgsIHZhbHVlTGVuZ3RoLCBib3hTaXplLCBib3hNYnJdIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVCb3hDb25maWd1cmF0aW9uIiwiZGVzYyI6IlVwZGF0ZXMgdGhlIGJveCBzaXplIGNvbmZpZ3VyYXRpb24gdmFsdWVzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0tleUxlbmd0aCIsImRlc2MiOiJUaGUgbmV3IGtleSBsZW5ndGgiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1ZhbHVlTGVuZ3RoIiwiZGVzYyI6IlRoZSBuZXcgdmFsdWUgbGVuZ3RoIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gdGhlIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGNvdmVyIHRoZSBib3ggTUJSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzYsMTc5LDI3OCwyODksMjk0LDI5OSwzMDMsMzQ0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRGdnTkRBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKclpYbE1aVzVuZEdnaUlDSmliM2hOWW5JaUlDSmpiM1Z1ZEdWeUlpQXdlREUxTVdZM1l6YzFJQ0oyWVd4MVpVeGxibWQwYUNJZ0ltSnZlRk5wZW1VaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEIxWW14cFl5QnJaWGxNWlc1bmRHZ2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NeklnS3lBeE9Ta2dmU2tnTHk4Z1FXTmpiM1Z1ZENCaFpHUnlaWE56SUNnek1pQmllWFJsY3lrZ0t5QnJaWGtnY0hKbFptbDRJRzkyWlhKb1pXRmtJQ2d4T1NCaWVYUmxjeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXRsZVV4bGJtZDBhQ0lLSUNBZ0lIQjFjMmhwYm5RZ05URWdMeThnTlRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhCMVlteHBZeUIyWVd4MVpVeGxibWQwYUNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnNEtTQjlLU0F2THlCMWFXNTBOalFnS0RnZ1lubDBaWE1wQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0oyWVd4MVpVeGxibWQwYUNJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRk5wZW1VdWRtRnNkV1VnUFNCMGFHbHpMbXRsZVV4bGJtZDBhQzUyWVd4MVpTQXJJSFJvYVhNdWRtRnNkV1ZNWlc1bmRHZ3VkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEIxWW14cFl5QnJaWGxNWlc1bmRHZ2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NeklnS3lBeE9Ta2dmU2tnTHk4Z1FXTmpiM1Z1ZENCaFpHUnlaWE56SUNnek1pQmllWFJsY3lrZ0t5QnJaWGtnY0hKbFptbDRJRzkyWlhKb1pXRmtJQ2d4T1NCaWVYUmxjeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXRsZVV4bGJtZDBhQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaFRhWHBsTG5aaGJIVmxJRDBnZEdocGN5NXJaWGxNWlc1bmRHZ3VkbUZzZFdVZ0t5QjBhR2x6TG5aaGJIVmxUR1Z1WjNSb0xuWmhiSFZsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QndkV0pzYVdNZ2RtRnNkV1ZNWlc1bmRHZ2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9PQ2tnZlNrZ0x5OGdkV2x1ZERZMElDZzRJR0o1ZEdWektRb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnZEdocGN5NWliM2hUYVhwbExuWmhiSFZsSUQwZ2RHaHBjeTVyWlhsTVpXNW5kR2d1ZG1Gc2RXVWdLeUIwYUdsekxuWmhiSFZsVEdWdVozUm9MblpoYkhWbENpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hUYVhwbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwSUM4dklFTmhiR04xYkdGMFpXUWdhVzRnWTI5dWMzUnlkV04wYjNJS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1KdmVGTnBlbVVpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJSFJvYVhNdVltOTRVMmw2WlM1MllXeDFaU0E5SUhSb2FYTXVhMlY1VEdWdVozUm9MblpoYkhWbElDc2dkR2hwY3k1MllXeDFaVXhsYm1kMGFDNTJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdKeUxuWmhiSFZsSUQwZ1ZXbHVkRFkwS0RJMU1EQXBJQ3NnZEdocGN5NWliM2hUYVhwbExuWmhiSFZsSUNvZ1ZXbHVkRFkwS0RRd01Da2dMeThnUW1GelpTQk5RbElnS3lBb2MybDZaU0FxSUhCbGNpMWllWFJsSUdOdmMzUXBDaUFnSUNCcGJuUmpYek1nTHk4Z05EQXdDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREkxTURBZ0x5OGdNalV3TUFvZ0lDQWdLd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0p5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SUVOaGJHTjFiR0YwWldRZ2FXNGdZMjl1YzNSeWRXTjBiM0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUp2ZUUxaWNpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTlluSXVkbUZzZFdVZ1BTQlZhVzUwTmpRb01qVXdNQ2tnS3lCMGFHbHpMbUp2ZUZOcGVtVXVkbUZzZFdVZ0tpQlZhVzUwTmpRb05EQXdLU0F2THlCQ1lYTmxJRTFDVWlBcklDaHphWHBsSUNvZ2NHVnlMV0o1ZEdVZ1kyOXpkQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1pMHlNd29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2daMnh2WW1Gc1ZXbHVkSE02SURRZ2ZTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nVW1WbVpYSmxibU5sUVhCd1FtOTRJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQTBNR0V5TXpWbElEQjROVFF5TldFeE5EVWdNSGhsT1RJMFpUVmxNQ0F3ZUdKaVlqVXlNemxsSURCNE1XRmxabVUzWmpVZ01IZ3daVE00TlRFMk1pQXZMeUJ0WlhSb2IyUWdJbWx1WTNKbGJXVnVkRUp2ZUVOdmRXNTBaWElvY0dGNUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRbTk0UTI5MWJuUmxjaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSQ2IzaERiM1Z1ZEdWeVJtOXlRV05qYjNWdWRDaGhaR1J5WlhOektYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRbTk0VFdKeUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRUp2ZUVOdmJtWnBaM1Z5WVhScGIyNG9LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZDYjNoRGIyNW1hV2QxY21GMGFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdsdVkzSmxiV1Z1ZEVKdmVFTnZkVzUwWlhJZ1oyVjBRbTk0UTI5MWJuUmxjaUJuWlhSQ2IzaERiM1Z1ZEdWeVJtOXlRV05qYjNWdWRDQm5aWFJDYjNoTlluSWdaMlYwUW05NFEyOXVabWxuZFhKaGRHbHZiaUIxY0dSaGRHVkNiM2hEYjI1bWFXZDFjbUYwYVc5dUNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUxT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TFRJekNpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QnpkR0YwWlZSdmRHRnNjem9nZXlCbmJHOWlZV3hWYVc1MGN6b2dOQ0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5QlNaV1psY21WdVkyVkJjSEJDYjNnZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJpQXZMeUJ2YmlCbGNuSnZjam9nVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0Nnb3ZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNXBibU55WlcxbGJuUkNiM2hEYjNWdWRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1amNtVnRaVzUwUW05NFEyOTFiblJsY2pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1MwMU1Bb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nYVc1amNtVnRaVzUwUW05NFEyOTFiblJsY2lod1lYbE5Zbkk2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVVMWljaTVoYlc5MWJuUWdQVDA5SUhSb2FYTXVZbTk0VFdKeUxuWmhiSFZsTENBblVHRjViV1Z1ZENCdGRYTjBJR052ZG1WeUlIUm9aU0JpYjNnZ1RVSlNKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2RXSnNhV01nWW05NFRXSnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncElDOHZJRU5oYkdOMWJHRjBaV1FnYVc0Z1kyOXVjM1J5ZFdOMGIzSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnZlRTFpY2lJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVUxaWNpNWhiVzkxYm5RZ1BUMDlJSFJvYVhNdVltOTRUV0p5TG5aaGJIVmxMQ0FuVUdGNWJXVnVkQ0J0ZFhOMElHTnZkbVZ5SUhSb1pTQmliM2dnVFVKU0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCamIzWmxjaUIwYUdVZ1ltOTRJRTFDVWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1VFdKeUxuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dKMUJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUIwYUdVZ1kyOXVkSEpoWTNRbktRb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCMGFHVWdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdGalkyOTFiblJDYjNoRGIzVnVkR1Z5SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGpiM1Z1ZEdWeUp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJOdmRXNTBaWElzSUdoaGMwTnZkVzUwWlhKZElEMGdkR2hwY3k1aFkyTnZkVzUwUW05NFEyOTFiblJsY2loVWVHNHVjMlZ1WkdWeUtTNXRZWGxpWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEIxWW14cFl5QmhZMk52ZFc1MFFtOTRRMjkxYm5SbGNpQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWTI5MWJuUmxjaWNnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCamIyNXpkQ0JiWTI5MWJuUmxjaXdnYUdGelEyOTFiblJsY2wwZ1BTQjBhR2x6TG1GalkyOTFiblJDYjNoRGIzVnVkR1Z5S0ZSNGJpNXpaVzVrWlhJcExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z2FXWWdLR2hoYzBOdmRXNTBaWElwSUhzS0lDQWdJR0o2SUdsdVkzSmxiV1Z1ZEVKdmVFTnZkVzUwWlhKZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2RHaHBjeTVoWTJOdmRXNTBRbTk0UTI5MWJuUmxjaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOdmRXNTBaWElnS3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQjFZbXhwWXlCaFkyTnZkVzUwUW05NFEyOTFiblJsY2lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMjkxYm5SbGNpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU52ZFc1MFpYSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11WVdOamIzVnVkRUp2ZUVOdmRXNTBaWElvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCamIzVnVkR1Z5SUNzZ01Rb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZV05qYjNWdWRFSnZlRU52ZFc1MFpYSWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJOdmRXNTBaWEluSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2RHaHBjeTVoWTJOdmRXNTBRbTk0UTI5MWJuUmxjaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOdmRXNTBaWElnS3lBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9LYVc1amNtVnRaVzUwUW05NFEyOTFiblJsY2w5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZtWlhKbGJtTmxRWEJ3UW05NExtbHVZM0psYldWdWRFSnZlRU52ZFc1MFpYSkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUzAxTUFvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzVqY21WdFpXNTBRbTk0UTI5MWJuUmxjaWh3WVhsTlluSTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYm1OeVpXMWxiblJDYjNoRGIzVnVkR1Z5WDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCd2RXSnNhV01nWVdOamIzVnVkRUp2ZUVOdmRXNTBaWElnUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTnZkVzUwWlhJbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpiM1Z1ZEdWeUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCMGFHbHpMbUZqWTI5MWJuUkNiM2hEYjNWdWRHVnlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnVldsdWREWTBLREVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQjFZbXhwWXlCaFkyTnZkVzUwUW05NFEyOTFiblJsY2lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMjkxYm5SbGNpY2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIwYUdsekxtRmpZMjkxYm5SQ2IzaERiM1Z1ZEdWeUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdWV2x1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QnlaWFIxY200Z1ZXbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1TFRVd0NpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJwYm1OeVpXMWxiblJDYjNoRGIzVnVkR1Z5S0hCaGVVMWljam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSWdhVzVqY21WdFpXNTBRbTk0UTI5MWJuUmxjbDloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVtVm1aWEpsYm1ObFFYQndRbTk0TG1sdVkzSmxiV1Z1ZEVKdmVFTnZkVzUwWlhKQU5Bb0tDaTh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WbVpYSmxibU5sUVhCd1FtOTRMbWRsZEVKdmVFTnZkVzUwWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJDYjNoRGIzVnVkR1Z5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZV05qYjNWdWRFSnZlRU52ZFc1MFpYSWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJOdmRXNTBaWEluSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamIzVnVkR1Z5SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJqYjI1emRDQmJZMjkxYm5SbGNpd2dhR0Z6UTI5MWJuUmxjbDBnUFNCMGFHbHpMbUZqWTI5MWJuUkNiM2hEYjNWdWRHVnlLRlI0Ymk1elpXNWtaWElwTG0xaGVXSmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdGalkyOTFiblJDYjNoRGIzVnVkR1Z5SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGpiM1Z1ZEdWeUp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJR052Ym5OMElGdGpiM1Z1ZEdWeUxDQm9ZWE5EYjNWdWRHVnlYU0E5SUhSb2FYTXVZV05qYjNWdWRFSnZlRU52ZFc1MFpYSW9WSGh1TG5ObGJtUmxjaWt1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJwWmlBb2FHRnpRMjkxYm5SbGNpa2dld29nSUNBZ1lub2daMlYwUW05NFEyOTFiblJsY2w5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lHUjFjQW9LWjJWMFFtOTRRMjkxYm5SbGNsOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WbVpYSmxibU5sUVhCd1FtOTRMbWRsZEVKdmVFTnZkVzUwWlhKQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01pMDNNd29nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBRbTk0UTI5MWJuUmxjaWdwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBRbTk0UTI5MWJuUmxjbDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklISmxkSFZ5YmlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5TFRjekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSQ2IzaERiM1Z1ZEdWeUtDazZJSFZwYm5RMk5DQjdDaUFnSUNCaUlHZGxkRUp2ZUVOdmRXNTBaWEpmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxabVZ5Wlc1alpVRndjRUp2ZUM1blpYUkNiM2hEYjNWdWRHVnlRRFFLQ2dvdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxabVZ5Wlc1alpVRndjRUp2ZUM1blpYUkNiM2hEYjNWdWRHVnlSbTl5UVdOamIzVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFSnZlRU52ZFc1MFpYSkdiM0pCWTJOdmRXNTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QndkV0pzYVdNZ1lXTmpiM1Z1ZEVKdmVFTnZkVzUwWlhJZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKMk52ZFc1MFpYSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRMVGc1Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJDYjNoRGIzVnVkR1Z5Um05eVFXTmpiM1Z1ZENoaFkyTnZkVzUwT2lCQlkyTnZkVzUwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY0hWaWJHbGpJR0ZqWTI5MWJuUkNiM2hEYjNWdWRHVnlJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkamIzVnVkR1Z5SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHTnZibk4wSUZ0amIzVnVkR1Z5TENCb1lYTkRiM1Z1ZEdWeVhTQTlJSFJvYVhNdVlXTmpiM1Z1ZEVKdmVFTnZkVzUwWlhJb1lXTmpiM1Z1ZENrdWJXRjVZbVVvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCcFppQW9hR0Z6UTI5MWJuUmxjaWtnZXdvZ0lDQWdZbm9nWjJWMFFtOTRRMjkxYm5SbGNrWnZja0ZqWTI5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0JrZFhBS0NtZGxkRUp2ZUVOdmRXNTBaWEpHYjNKQlkyTnZkVzUwWDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFNaV1psY21WdVkyVkJjSEJDYjNndVoyVjBRbTk0UTI5MWJuUmxja1p2Y2tGalkyOTFiblJBTkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0MwNE9Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFFtOTRRMjkxYm5SbGNrWnZja0ZqWTI5MWJuUW9ZV05qYjNWdWREb2dRV05qYjNWdWRDazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSQ2IzaERiM1Z1ZEdWeVJtOXlRV05qYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUhKbGRIVnliaUF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRMVGc1Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJDYjNoRGIzVnVkR1Z5Um05eVFXTmpiM1Z1ZENoaFkyTnZkVzUwT2lCQlkyTnZkVzUwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0lnWjJWMFFtOTRRMjkxYm5SbGNrWnZja0ZqWTI5MWJuUmZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xKbFptVnlaVzVqWlVGd2NFSnZlQzVuWlhSQ2IzaERiM1Z1ZEdWeVJtOXlRV05qYjNWdWRFQTBDZ29LTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pXWmxjbVZ1WTJWQmNIQkNiM2d1WjJWMFFtOTRUV0p5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRbTk0VFdKeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZbTk0VFdKeUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZ3Y0VKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0p5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SUVOaGJHTjFiR0YwWldRZ2FXNGdZMjl1YzNSeWRXTjBiM0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUp2ZUUxaWNpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUp2ZUUxaWNpNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRE10TVRBMENpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSQ2IzaE5ZbklvS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNW5aWFJDYjNoRGIyNW1hV2QxY21GMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFFtOTRRMjl1Wm1sbmRYSmhkR2x2YmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUhKbGRIVnliaUJiZEdocGN5NXJaWGxNWlc1bmRHZ3VkbUZzZFdVc0lIUm9hWE11ZG1Gc2RXVk1aVzVuZEdndWRtRnNkV1VzSUhSb2FYTXVZbTk0VTJsNlpTNTJZV3gxWlN3Z2RHaHBjeTVpYjNoTlluSXVkbUZzZFdWZENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGd2NFSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhMlY1VEdWdVozUm9JRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLRE15SUNzZ01Ua3BJSDBwSUM4dklFRmpZMjkxYm5RZ1lXUmtjbVZ6Y3lBb016SWdZbmwwWlhNcElDc2dhMlY1SUhCeVpXWnBlQ0J2ZG1WeWFHVmhaQ0FvTVRrZ1lubDBaWE1wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pyWlhsTVpXNW5kR2dpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdXM1JvYVhNdWEyVjVUR1Z1WjNSb0xuWmhiSFZsTENCMGFHbHpMblpoYkhWbFRHVnVaM1JvTG5aaGJIVmxMQ0IwYUdsekxtSnZlRk5wZW1VdWRtRnNkV1VzSUhSb2FYTXVZbTk0VFdKeUxuWmhiSFZsWFFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklIQjFZbXhwWXlCMllXeDFaVXhsYm1kMGFDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZzRLU0I5S1NBdkx5QjFhVzUwTmpRZ0tEZ2dZbmwwWlhNcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMllXeDFaVXhsYm1kMGFDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UUUtJQ0FnSUM4dklISmxkSFZ5YmlCYmRHaHBjeTVyWlhsTVpXNW5kR2d1ZG1Gc2RXVXNJSFJvYVhNdWRtRnNkV1ZNWlc1bmRHZ3VkbUZzZFdVc0lIUm9hWE11WW05NFUybDZaUzUyWVd4MVpTd2dkR2hwY3k1aWIzaE5Zbkl1ZG1Gc2RXVmRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnY0hWaWJHbGpJR0p2ZUZOcGVtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0x5OGdRMkZzWTNWc1lYUmxaQ0JwYmlCamIyNXpkSEoxWTNSdmNnb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVltOTRVMmw2WlNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUhKbGRIVnliaUJiZEdocGN5NXJaWGxNWlc1bmRHZ3VkbUZzZFdVc0lIUm9hWE11ZG1Gc2RXVk1aVzVuZEdndWRtRnNkV1VzSUhSb2FYTXVZbTk0VTJsNlpTNTJZV3gxWlN3Z2RHaHBjeTVpYjNoTlluSXVkbUZzZFdWZENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjSFZpYkdsaklHSnZlRTFpY2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LU0F2THlCRFlXeGpkV3hoZEdWa0lHbHVJR052Ym5OMGNuVmpkRzl5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYjNoTlluSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QnlaWFIxY200Z1czUm9hWE11YTJWNVRHVnVaM1JvTG5aaGJIVmxMQ0IwYUdsekxuWmhiSFZsVEdWdVozUm9MblpoYkhWbExDQjBhR2x6TG1KdmVGTnBlbVV1ZG1Gc2RXVXNJSFJvYVhNdVltOTRUV0p5TG5aaGJIVmxYUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEl0TVRFekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSQ2IzaERiMjVtYVdkMWNtRjBhVzl1S0NrNklGdDFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalJkSUhzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNTFjR1JoZEdWQ2IzaERiMjVtYVdkMWNtRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUW05NFEyOXVabWxuZFhKaGRHbHZiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakl0TVRJekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVkNiM2hEYjI1bWFXZDFjbUYwYVc5dUtHNWxkMHRsZVV4bGJtZDBhRG9nZFdsdWREWTBMQ0J1WlhkV1lXeDFaVXhsYm1kMGFEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFYQndRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhCMVlteHBZeUJyWlhsTVpXNW5kR2dnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTXpJZ0t5QXhPU2tnZlNrZ0x5OGdRV05qYjNWdWRDQmhaR1J5WlhOeklDZ3pNaUJpZVhSbGN5a2dLeUJyWlhrZ2NISmxabWw0SUc5MlpYSm9aV0ZrSUNneE9TQmllWFJsY3lrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW10bGVVeGxibWQwYUNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpRS0lDQWdJQzh2SUhSb2FYTXVhMlY1VEdWdVozUm9MblpoYkhWbElEMGdibVYzUzJWNVRHVnVaM1JvQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklIQjFZbXhwWXlCMllXeDFaVXhsYm1kMGFDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZzRLU0I5S1NBdkx5QjFhVzUwTmpRZ0tEZ2dZbmwwWlhNcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMllXeDFaVXhsYm1kMGFDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklIUm9hWE11ZG1Gc2RXVk1aVzVuZEdndWRtRnNkV1VnUFNCdVpYZFdZV3gxWlV4bGJtZDBhQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk0Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRk5wZW1VdWRtRnNkV1VnUFNCMGFHbHpMbXRsZVV4bGJtZDBhQzUyWVd4MVpTQXJJSFJvYVhNdWRtRnNkV1ZNWlc1bmRHZ3VkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEIxWW14cFl5QnJaWGxNWlc1bmRHZ2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NeklnS3lBeE9Ta2dmU2tnTHk4Z1FXTmpiM1Z1ZENCaFpHUnlaWE56SUNnek1pQmllWFJsY3lrZ0t5QnJaWGtnY0hKbFptbDRJRzkyWlhKb1pXRmtJQ2d4T1NCaWVYUmxjeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXRsZVV4bGJtZDBhQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlTWldabGNtVnVZMlZCY0hCQ2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJSFJvYVhNdVltOTRVMmw2WlM1MllXeDFaU0E5SUhSb2FYTXVhMlY1VEdWdVozUm9MblpoYkhWbElDc2dkR2hwY3k1MllXeDFaVXhsYm1kMGFDNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVGTnBlbVVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa2dMeThnUTJGc1kzVnNZWFJsWkNCcGJpQmpiMjV6ZEhKMVkzUnZjZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlZbTk0VTJsNlpTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJjSEJDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qZ0tJQ0FnSUM4dklIUm9hWE11WW05NFUybDZaUzUyWVd4MVpTQTlJSFJvYVhNdWEyVjVUR1Z1WjNSb0xuWmhiSFZsSUNzZ2RHaHBjeTUyWVd4MVpVeGxibWQwYUM1MllXeDFaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVhCd1FtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFpY2k1MllXeDFaU0E5SUZWcGJuUTJOQ2d5TlRBd0tTQXJJSFJvYVhNdVltOTRVMmw2WlM1MllXeDFaU0FxSUZWcGJuUTJOQ2cwTURBcENpQWdJQ0JwYm5Salh6TWdMeThnTkRBd0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESTFNREFnTHk4Z01qVXdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRndjRUp2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2RXSnNhV01nWW05NFRXSnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncElDOHZJRU5oYkdOMWJHRjBaV1FnYVc0Z1kyOXVjM1J5ZFdOMGIzSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnZlRTFpY2lJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQmNIQkNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWprS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdKeUxuWmhiSFZsSUQwZ1ZXbHVkRFkwS0RJMU1EQXBJQ3NnZEdocGN5NWliM2hUYVhwbExuWmhiSFZsSUNvZ1ZXbHVkRFkwS0RRd01Da0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRWEJ3UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXlMVEV5TXdvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWEJrWVhSbFFtOTRRMjl1Wm1sbmRYSmhkR2x2YmlodVpYZExaWGxNWlc1bmRHZzZJSFZwYm5RMk5Dd2dibVYzVm1Gc2RXVk1aVzVuZEdnNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlrQU1tQmdsclpYbE1aVzVuZEdnR1ltOTRUV0p5QjJOdmRXNTBaWElFRlI5OGRRdDJZV3gxWlV4bGJtZDBhQWRpYjNoVGFYcGxNUmhBQUJ3b2dUTm5Kd1FrWnlNb1pVUWtDQ2NGU3dGbkpRdUJ4Qk1JS1V4bk1SdEJBRGt4R1JSRU1SaEVnZ1lFQkFvalhnUlVKYUZGQk9razVlQUV1N1VqbmdRYTcrZjFCQTQ0VVdJMkdnQ09CZ0FKQUVvQVlRQjVBSVFBcWdBeEdSUXhHQlFRUXpFV0lnbEpPQkFpRWtSSk9BZ2pLV1ZFRWtRNEJ6SUtFa1FxTVFCUXZrd1hURUVBRWtraUNDb3hBRkJMQVJhL0ZpdE1VTEFpUXlveEFGQWlGcjhpUXYvdUtqRUFVTDVNRjB4QkFBaEpGaXRNVUxBaVF5TkMvL1VxTmhvQlVMNU1GMHhCQUFoSkZpdE1VTEFpUXlOQy8vVWpLV1ZFRml0TVVMQWlReU1vWlVRakp3UmxSQ01uQldWRUl5bGxSRThERms4REZsQlBBaFpRVEJaUUsweFFzQ0pETmhvQkZ6WWFBaGNvVHdKbkp3UkxBV2NqS0dWRUNDY0ZTd0ZuSlF1QnhCTUlLVXhuSWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
