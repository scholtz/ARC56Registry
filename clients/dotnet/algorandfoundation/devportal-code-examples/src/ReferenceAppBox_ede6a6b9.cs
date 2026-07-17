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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAppBox_ede6a6b9
{


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
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_mbr"> </param>
        public async Task<ulong> IncrementBoxCounter(PaymentTransaction pay_mbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_mbr });
            byte[] abiHandle = { 3, 92, 143, 153 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IncrementBoxCounter_Transactions(PaymentTransaction pay_mbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_mbr });
            byte[] abiHandle = { 3, 92, 143, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetBoxCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 21, 153, 45 };

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
            byte[] abiHandle = { 196, 21, 153, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> GetBoxCounterForAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 119, 133, 1 };
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
            byte[] abiHandle = { 224, 119, 133, 1 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetBoxMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 86, 134, 29 };

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
            byte[] abiHandle = { 51, 86, 134, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetBoxConfigurationReturn> GetBoxConfiguration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 62, 160, 233 };

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
            byte[] abiHandle = { 26, 62, 160, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_key_length"> </param>
        /// <param name="new_value_length"> </param>
        public async Task UpdateBoxConfiguration(ulong new_key_length, ulong new_value_length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 155, 39, 64 };
            var new_key_lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_key_lengthAbi.From(new_key_length);
            var new_value_lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_value_lengthAbi.From(new_value_length);

            var result = await base.CallApp(new List<object> { abiHandle, new_key_lengthAbi, new_value_lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBoxConfiguration_Transactions(ulong new_key_length, ulong new_value_length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 155, 39, 64 };
            var new_key_lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_key_lengthAbi.From(new_key_length);
            var new_value_lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_value_lengthAbi.From(new_value_length);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_key_lengthAbi, new_value_lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQXBwQm94IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldEJveENvbmZpZ3VyYXRpb25SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfYm94X2NvdW50ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5X21iciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ib3hfY291bnRlciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JveF9jb3VudGVyX2Zvcl9hY2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYm94X21iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JveF9jb25maWd1cmF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Qm94Q29uZmlndXJhdGlvblJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2JveF9jb25maWd1cmF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19rZXlfbGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdmFsdWVfbGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAwXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIHRvIHRoZSBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBjb3ZlciB0aGUgYm94IE1CUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNywyMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjY291bnRfYm94X2NvdW50ZXIgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyLDI5OCwzMjNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJveF9tYnIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3hfc2l6ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsMzA5LDM2NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYua2V5X2xlbmd0aCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjAsMzE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52YWx1ZV9sZW5ndGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ05EQXdJREkxTURBS0lDQWdJR0o1ZEdWallteHZZMnNnSW1OdmRXNTBaWElpSUNKclpYbGZiR1Z1WjNSb0lpQWlZbTk0WDIxaWNpSWdNSGd4TlRGbU4yTTNOU0FpZG1Gc2RXVmZiR1Z1WjNSb0lpQWlZbTk0WDNOcGVtVWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk1UZ3RNVGtLSUNBZ0lDOHZJQ01nUkdWbWFXNWxJR052Ym5OMFlXNTBjeUJtYjNJZ1ltOTRJSE4wYjNKaFoyVWdhVzRnWjJ4dlltRnNJSE4wWVhSbENpQWdJQ0F2THlCelpXeG1MbXRsZVY5c1pXNW5kR2dnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltdGxlVjlzWlc1bmRHZ2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRndjRjlpYjNndlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJRlZKYm5RMk5DaERUMVZPVkVWU1gwSlBXRjlMUlZsZlRFVk9SMVJJS1FvZ0lDQWdjSFZ6YUdsdWRDQTFNU0F2THlBMU1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qRTRMVEl4Q2lBZ0lDQXZMeUFqSUVSbFptbHVaU0JqYjI1emRHRnVkSE1nWm05eUlHSnZlQ0J6ZEc5eVlXZGxJR2x1SUdkc2IySmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTVyWlhsZmJHVnVaM1JvSUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLRU5QVlU1VVJWSmZRazlZWDB0RldWOU1SVTVIVkVncENpQWdJQ0F2THlBcElDQWpJRUZqWTI5MWJuUWdZV1JrY21WemN5QW9NeklnWW5sMFpYTXBJQ3NnYTJWNUlIQnlaV1pwZUNCdmRtVnlhR1ZoWkNBb01Ua2dZbmwwWlhNcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QnpaV3htTG5aaGJIVmxYMnhsYm1kMGFDQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZG1Gc2RXVmZiR1Z1WjNSb0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QlZTVzUwTmpRb1EwOVZUbFJGVWw5Q1QxaGZWa0ZNVlVWZlRFVk9SMVJJS1FvZ0lDQWdjSFZ6YUdsdWRDQTRJQzh2SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRveU1pMHlOQW9nSUNBZ0x5OGdjMlZzWmk1MllXeDFaVjlzWlc1bmRHZ2dQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1EwOVZUbFJGVWw5Q1QxaGZWa0ZNVlVWZlRFVk9SMVJJS1FvZ0lDQWdMeThnS1NBZ0l5QjFhVzUwTmpRZ0tEZ2dZbmwwWlhNcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUdOc1lYTnpJRkpsWm1WeVpXNWpaVUZ3Y0VKdmVDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV5Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TURNMVl6aG1PVGtnTUhoak5ERTFPVGt5WkNBd2VHVXdOemM0TlRBeElEQjRNek0xTmpnMk1XUWdNSGd4WVRObFlUQmxPU0F3ZURBMU9XSXlOelF3SUM4dklHMWxkR2h2WkNBaWFXNWpjbVZ0Wlc1MFgySnZlRjlqYjNWdWRHVnlLSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWliM2hmWTI5MWJuUmxjaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZlltOTRYMk52ZFc1MFpYSmZabTl5WDJGalkyOTFiblFvWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aWIzaGZiV0p5S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWliM2hmWTI5dVptbG5kWEpoZEdsdmJpZ3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjlpYjNoZlkyOXVabWxuZFhKaGRHbHZiaWgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcGJtTnlaVzFsYm5SZlltOTRYMk52ZFc1MFpYSWdaMlYwWDJKdmVGOWpiM1Z1ZEdWeUlHZGxkRjlpYjNoZlkyOTFiblJsY2w5bWIzSmZZV05qYjNWdWRDQm5aWFJmWW05NFgyMWljaUJuWlhSZlltOTRYMk52Ym1acFozVnlZWFJwYjI0Z2RYQmtZWFJsWDJKdmVGOWpiMjVtYVdkMWNtRjBhVzl1Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk1UWUtJQ0FnSUM4dklHTnNZWE56SUZKbFptVnlaVzVqWlVGd2NFSnZlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HTTFZell4WW1FZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM1amIyNTBjbUZqZEM1U1pXWmxjbVZ1WTJWQmNIQkNiM2d1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl6YVhwbExuWmhiSFZsSUQwZ2MyVnNaaTVyWlhsZmJHVnVaM1JvTG5aaGJIVmxJQ3NnYzJWc1ppNTJZV3gxWlY5c1pXNW5kR2d1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKclpYbGZiR1Z1WjNSb0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXRsZVY5c1pXNW5kR2dnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRtRnNkV1ZmYkdWdVozUm9JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5aaGJIVmxYMnhsYm1kMGFDQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUp2ZUY5emFYcGxJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TXpRdE16WUtJQ0FnSUM4dklITmxiR1l1WW05NFgyMWljaTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3lYelV3TUNrZ0t5QnpaV3htTG1KdmVGOXphWHBsTG5aaGJIVmxJQ29nVlVsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSURRd01Bb2dJQ0FnTHk4Z0tTQWdJeUJDWVhObElFMUNVaUFySUNoemFYcGxJQ29nY0dWeUxXSjVkR1VnWTI5emRDa0tJQ0FnSUdsdWRHTmZNaUF2THlBME1EQUtJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNoZmJXSnlMblpoYkhWbElEMGdWVWx1ZERZMEtESmZOVEF3S1NBcklITmxiR1l1WW05NFgzTnBlbVV1ZG1Gc2RXVWdLaUJWU1c1ME5qUW9DaUFnSUNCcGJuUmpYek1nTHk4Z01qVXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPak0wTFRNMkNpQWdJQ0F2THlCelpXeG1MbUp2ZUY5dFluSXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01sODFNREFwSUNzZ2MyVnNaaTVpYjNoZmMybDZaUzUyWVd4MVpTQXFJRlZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0EwTURBS0lDQWdJQzh2SUNrZ0lDTWdRbUZ6WlNCTlFsSWdLeUFvYzJsNlpTQXFJSEJsY2kxaWVYUmxJR052YzNRcENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUhObGJHWXVZbTk0WDIxaWNpNTJZV3gxWlNBOUlGVkpiblEyTkNneVh6VXdNQ2tnS3lCelpXeG1MbUp2ZUY5emFYcGxMblpoYkhWbElDb2dWVWx1ZERZMEtBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRYMjFpY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvek5DMHpOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZiV0p5TG5aaGJIVmxJRDBnVlVsdWREWTBLREpmTlRBd0tTQXJJSE5sYkdZdVltOTRYM05wZW1VdWRtRnNkV1VnS2lCVlNXNTBOalFvQ2lBZ0lDQXZMeUFnSUNBZ05EQXdDaUFnSUNBdkx5QXBJQ0FqSUVKaGMyVWdUVUpTSUNzZ0tITnBlbVVnS2lCd1pYSXRZbmwwWlNCamIzTjBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDNWpiMjUwY21GamRDNVNaV1psY21WdVkyVkJjSEJDYjNndWFXNWpjbVZ0Wlc1MFgySnZlRjlqYjNWdWRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1amNtVnRaVzUwWDJKdmVGOWpiM1Z1ZEdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvME55MDBPQW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dkR2hsSUhCaGVXMWxiblFnWTI5MlpYSnpJSFJvWlNCTlFsSWdZMjl6ZENCaGJtUWdhWE1nYzJWdWRDQjBieUIwYUdVZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsZmJXSnlMbUZ0YjNWdWRDQTlQU0J6Wld4bUxtSnZlRjl0WW5JdWRtRnNkV1VzSUNKUVlYbHRaVzUwSUcxMWMzUWdZMjkyWlhJZ2RHaGxJR0p2ZUNCTlFsSWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVGOXRZbklpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRYMjFpY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR052ZG1WeUlIUm9aU0JpYjNnZ1RVSlNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRndjRjlpYjNndlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSEJoZVY5dFluSXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPalE1TFRVeENpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lIQmhlVjl0WW5JdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2dJbEJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUIwYUdVZ1kyOXVkSEpoWTNRaUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUhSb1pTQmpiMjUwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmpiM1Z1ZEdWeUxDQm9ZWE5mWTI5MWJuUmxjaUE5SUhObGJHWXVZV05qYjNWdWRGOWliM2hmWTI5MWJuUmxjaTV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUdsbUlHaGhjMTlqYjNWdWRHVnlPZ29nSUNBZ1lub2dhVzVqY21WdFpXNTBYMkp2ZUY5amIzVnVkR1Z5WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1WVdOamIzVnVkRjlpYjNoZlkyOTFiblJsY2x0VWVHNHVjMlZ1WkdWeVhTQXJQU0F4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZqWTI5MWJuUmZZbTk0WDJOdmRXNTBaWElnWlc1MGNua2daWGhwYzNSekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hCZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWhZMk52ZFc1MFgySnZlRjlqYjNWdWRHVnlXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWTJOdmRXNTBYMkp2ZUY5amIzVnVkR1Z5SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb0thVzVqY21WdFpXNTBYMkp2ZUY5amIzVnVkR1Z5WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxabVZ5Wlc1alpWOWhjSEJmWW05NExtTnZiblJ5WVdOMExsSmxabVZ5Wlc1alpVRndjRUp2ZUM1cGJtTnlaVzFsYm5SZlltOTRYMk52ZFc1MFpYSkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FXNWpjbVZ0Wlc1MFgySnZlRjlqYjNWdWRHVnlYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hCZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCelpXeG1MbUZqWTI5MWJuUmZZbTk0WDJOdmRXNTBaWEpiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZkVzUwWlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR0lnYVc1amNtVnRaVzUwWDJKdmVGOWpiM1Z1ZEdWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWm1WeVpXNWpaVjloY0hCZlltOTRMbU52Ym5SeVlXTjBMbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNXBibU55WlcxbGJuUmZZbTk0WDJOdmRXNTBaWEpBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDNWpiMjUwY21GamRDNVNaV1psY21WdVkyVkJjSEJDYjNndVoyVjBYMkp2ZUY5amIzVnVkR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkp2ZUY5amIzVnVkR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hCZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCamIzVnVkR1Z5TENCb1lYTmZZMjkxYm5SbGNpQTlJSE5sYkdZdVlXTmpiM1Z1ZEY5aWIzaGZZMjkxYm5SbGNpNXRZWGxpWlNoVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOTFiblJsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QnBaaUJvWVhOZlkyOTFiblJsY2pvS0lDQWdJR0o2SUdkbGRGOWliM2hmWTI5MWJuUmxjbDloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUdSMWNBb0taMlYwWDJKdmVGOWpiM1Z1ZEdWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWm1WeVpXNWpaVjloY0hCZlltOTRMbU52Ym5SeVlXTjBMbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNW5aWFJmWW05NFgyTnZkVzUwWlhKQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDJKdmVGOWpiM1Z1ZEdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQm5aWFJmWW05NFgyTnZkVzUwWlhKZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3VZMjl1ZEhKaFkzUXVVbVZtWlhKbGJtTmxRWEJ3UW05NExtZGxkRjlpYjNoZlkyOTFiblJsY2tBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWm1WeVpXNWpaVjloY0hCZlltOTRMbU52Ym5SeVlXTjBMbEpsWm1WeVpXNWpaVUZ3Y0VKdmVDNW5aWFJmWW05NFgyTnZkVzUwWlhKZlptOXlYMkZqWTI5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlltOTRYMk52ZFc1MFpYSmZabTl5WDJGalkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUdOdmRXNTBaWElzSUdoaGMxOWpiM1Z1ZEdWeUlEMGdjMlZzWmk1aFkyTnZkVzUwWDJKdmVGOWpiM1Z1ZEdWeUxtMWhlV0psS0dGalkyOTFiblFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRndjRjlpYjNndlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJR052ZFc1MFpYSXNJR2hoYzE5amIzVnVkR1Z5SUQwZ2MyVnNaaTVoWTJOdmRXNTBYMkp2ZUY5amIzVnVkR1Z5TG0xaGVXSmxLR0ZqWTI5MWJuUXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z2FXWWdhR0Z6WDJOdmRXNTBaWEk2Q2lBZ0lDQmllaUJuWlhSZlltOTRYMk52ZFc1MFpYSmZabTl5WDJGalkyOTFiblJmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCa2RYQUtDbWRsZEY5aWIzaGZZMjkxYm5SbGNsOW1iM0pmWVdOamIzVnVkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM1amIyNTBjbUZqZEM1U1pXWmxjbVZ1WTJWQmNIQkNiM2d1WjJWMFgySnZlRjlqYjNWdWRHVnlYMlp2Y2w5aFkyTnZkVzUwUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjlpYjNoZlkyOTFiblJsY2w5bWIzSmZZV05qYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGd2NGOWliM2d2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDJKdmVGOWpiM1Z1ZEdWeVgyWnZjbDloWTJOdmRXNTBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5KbFptVnlaVzVqWlY5aGNIQmZZbTk0TG1OdmJuUnlZV04wTGxKbFptVnlaVzVqWlVGd2NFSnZlQzVuWlhSZlltOTRYMk52ZFc1MFpYSmZabTl5WDJGalkyOTFiblJBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDNWpiMjUwY21GamRDNVNaV1psY21WdVkyVkJjSEJDYjNndVoyVjBYMkp2ZUY5dFluSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlltOTRYMjFpY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0WDIxaWNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUY5dFluSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyMWljaUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WldabGNtVnVZMlZmWVhCd1gySnZlQzVqYjI1MGNtRmpkQzVTWldabGNtVnVZMlZCY0hCQ2IzZ3VaMlYwWDJKdmVGOWpiMjVtYVdkMWNtRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkp2ZUY5amIyNW1hV2QxY21GMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnYzJWc1ppNXJaWGxmYkdWdVozUm9MblpoYkhWbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW10bGVWOXNaVzVuZEdnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhMlY1WDJ4bGJtZDBhQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM5amIyNTBjbUZqZEM1d2VUb3hNRFVLSUNBZ0lDOHZJSE5sYkdZdWRtRnNkV1ZmYkdWdVozUm9MblpoYkhWbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5aaGJIVmxYMnhsYm1kMGFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyWVd4MVpWOXNaVzVuZEdnZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCelpXeG1MbUp2ZUY5emFYcGxMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1KdmVGOXphWHBsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZlRjl6YVhwbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloY0hCZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z2MyVnNaaTVpYjNoZmJXSnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVGOXRZbklpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRYMjFpY2lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVmZZWEJ3WDJKdmVDOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZtWlhKbGJtTmxYMkZ3Y0Y5aWIzZ3VZMjl1ZEhKaFkzUXVVbVZtWlhKbGJtTmxRWEJ3UW05NExuVndaR0YwWlY5aWIzaGZZMjl1Wm1sbmRYSmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlY5aWIzaGZZMjl1Wm1sbmRYSmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllYQndYMkp2ZUM5amIyNTBjbUZqZEM1d2VUb3hNakFLSUNBZ0lDOHZJSE5sYkdZdWEyVjVYMnhsYm1kMGFDNTJZV3gxWlNBOUlHNWxkMTlyWlhsZmJHVnVaM1JvQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pyWlhsZmJHVnVaM1JvSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnYzJWc1ppNTJZV3gxWlY5c1pXNW5kR2d1ZG1Gc2RXVWdQU0J1WlhkZmRtRnNkV1ZmYkdWdVozUm9DaUFnSUNCaWVYUmxZeUEwSUM4dklDSjJZV3gxWlY5c1pXNW5kR2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVhCd1gySnZlQzlqYjI1MGNtRmpkQzV3ZVRveE1qTXRNVEkwQ2lBZ0lDQXZMeUFqSUZKbFkyRnNZM1ZzWVhSbElHUmxjbWwyWldRZ2RtRnNkV1Z6Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl6YVhwbExuWmhiSFZsSUQwZ2MyVnNaaTVyWlhsZmJHVnVaM1JvTG5aaGJIVmxJQ3NnYzJWc1ppNTJZV3gxWlY5c1pXNW5kR2d1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKclpYbGZiR1Z1WjNSb0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXRsZVY5c1pXNW5kR2dnWlhocGMzUnpDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaWIzaGZjMmw2WlNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aGNIQmZZbTk0TDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdjMlZzWmk1aWIzaGZiV0p5TG5aaGJIVmxJRDBnVlVsdWREWTBLREpmTlRBd0tTQXJJSE5sYkdZdVltOTRYM05wZW1VdWRtRnNkV1VnS2lCVlNXNTBOalFvTkRBd0tRb2dJQ0FnYVc1MFkxOHlJQzh2SURRd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREkxTURBS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUY5dFluSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpWOWhjSEJmWW05NEwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFDUUE4UVRKZ1lIWTI5MWJuUmxjZ3ByWlhsZmJHVnVaM1JvQjJKdmVGOXRZbklFRlI5OGRReDJZV3gxWlY5c1pXNW5kR2dJWW05NFgzTnBlbVV4R0VBQUNTbUJNMmNuQklFSVp6RVpGRVF4R0VFQU1vSUdCQU5jajVrRXhCV1pMUVRnZDRVQkJETldoaDBFR2o2ZzZRUUZteWRBTmhvQWpnWUFKd0J2QUlZQW5nQ3BBTThBZ0FSTVhHRzZOaG9BamdFQUFRQWpLV1ZFSXljRVpVUUlKd1ZMQVdja0N5VUlLa3huSWtNeEZpSUpTVGdRSWhKRVNUZ0lJeXBsUkJKRU9BY3lDaEpFS0RFQVVMMUZBVUVBR2lneEFGQkp2a1FYSWdnV3Z5Z3hBRkMrUkJjV0sweFFzQ0pES0RFQVVDSVd2eUpDLys0b01RQlF2a3dYVEVFQUNFa1dLMHhRc0NKREkwTC85U2cyR2dGUXZrd1hURUVBQ0VrV0sweFFzQ0pESTBMLzlTTXFaVVFXSzB4UXNDSkRJeWxsUkNNbkJHVkVJeWNGWlVRakttVkVUd01XVHdNV1VFOENGbEJNRmxBclRGQ3dJa00yR2dFWE5ob0NGeWxQQW1jbkJFc0JaeU1wWlVRSUp3VkxBV2NrQ3lVSUtreG5Ja009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
