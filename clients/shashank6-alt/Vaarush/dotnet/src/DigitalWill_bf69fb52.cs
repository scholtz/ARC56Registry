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

namespace Arc56.Generated.shashank6_alt.Vaarush.DigitalWill_bf69fb52
{


    public class DigitalWillProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DigitalWillProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Beneficiary : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong SharePercent { get; set; }

                public bool Claimed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharePercent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSharePercent.From(SharePercent);
                    ret.AddRange(vSharePercent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vClaimed.From(Claimed);
                    ret.AddRange(vClaimed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Beneficiary Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Beneficiary();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharePercent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSharePercent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSharePercent = vSharePercent.ToValue();
                    if (valueSharePercent is ulong vSharePercentValue) { ret.SharePercent = vSharePercentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClaimed = vClaimed.ToValue();
                    if (valueClaimed is bool vClaimedValue) { ret.Claimed = vClaimedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Beneficiary);
                }
                public bool Equals(Beneficiary? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Beneficiary left, Beneficiary right)
                {
                    return EqualityComparer<Beneficiary>.Default.Equals(left, right);
                }
                public static bool operator !=(Beneficiary left, Beneficiary right)
                {
                    return !(left == right);
                }

            }

            public class GetWillStatusReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public bool Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetWillStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetWillStatusReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
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
                    return Equals(obj as GetWillStatusReturn);
                }
                public bool Equals(GetWillStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetWillStatusReturn left, GetWillStatusReturn right)
                {
                    return EqualityComparer<GetWillStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetWillStatusReturn left, GetWillStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="release_date"> </param>
        public async Task Create(ulong release_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var release_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); release_dateAbi.From(release_date);

            var result = await base.CallApp(new List<object> { abiHandle, release_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong release_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var release_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); release_dateAbi.From(release_date);

            return await base.MakeTransactionList(new List<object> { abiHandle, release_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="share_percent"> </param>
        public async Task AddBeneficiary(Algorand.Address address, ulong share_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 30, 229, 123 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var share_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentAbi.From(share_percent);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi, share_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddBeneficiary_Transactions(Algorand.Address address, ulong share_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 30, 229, 123 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var share_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentAbi.From(share_percent);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, share_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="share_percent"> </param>
        public async Task UpdateBeneficiary(ulong index, ulong share_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 162, 130, 181 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var share_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentAbi.From(share_percent);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, share_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBeneficiary_Transactions(ulong index, ulong share_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 162, 130, 181 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var share_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_percentAbi.From(share_percent);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, share_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(ulong payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 46, 188, 155 };
            var paymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAbi.From(payment);

            var result = await base.CallApp(new List<object> { abiHandle, paymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(ulong payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 46, 188, 155 };
            var paymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAbi.From(payment);

            return await base.MakeTransactionList(new List<object> { abiHandle, paymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TriggerManualRelease(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 120, 244, 119 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TriggerManualRelease_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 120, 244, 119 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task Claim(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 29, 47, 15 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Claim_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 29, 47, 15 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<Structs.Beneficiary> GetBeneficiary(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 84, 178, 113 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Beneficiary.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBeneficiary_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 84, 178, 113 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetWillStatusReturn> GetWillStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 51, 15, 231 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetWillStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetWillStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 51, 15, 231 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbFdpbGwiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmVuZWZpY2lhcnkiOlt7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzaGFyZV9wZXJjZW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsYWltZWQiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0V2lsbFN0YXR1c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVsZWFzZV9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9iZW5lZmljaWFyeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVfcGVyY2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfYmVuZWZpY2lhcnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlX3BlcmNlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyaWdnZXJfbWFudWFsX3JlbGVhc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JlbmVmaWNpYXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IkJlbmVmaWNpYXJ5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfd2lsbF9zdGF0dXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LGJvb2wsdWludDY0KSIsInN0cnVjdCI6IkdldFdpbGxTdGF0dXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6Nn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDM0XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDldLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGNsYWltZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTddLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgZWRpdCBhIGJlbmVmaWNpYXJ5IHdobyBhbHJlYWR5IGNsYWltZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODIsMzg0LDUwNCw3MDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsMjIwLDIzMywyNzAsMzY4LDQ5Myw1MzQsNjg2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iZW5lZmljaWFyeV9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQsNTI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYW51YWxfcmVsZWFzZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsMjYyLDMzOCwzNDgsNTE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTYsNTIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWxlYXNlX2RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0LDM3Miw0OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGJlbmVmaWNpYXJ5IGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSwxODgsMjQ4LDI1NiwzMzIsMzYzLDQ4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2xvdCBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6Im1heCBiZW5lZmljaWFyaWVzIHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IG93bmVyIGNhbiBhZGQgYmVuZWZpY2lhcmllcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MF0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3duZXIgY2FuIGZ1bmQgdGhlIHdpbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTBdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IG93bmVyIGNhbiB0cmlnZ2VyIG1hbnVhbCByZWxlYXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY0XSwiZXJyb3JNZXNzYWdlIjoib25seSBvd25lciBjYW4gdXBkYXRlIGJlbmVmaWNpYXJpZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBuYW1lZCBiZW5lZmljaWFyeSBjYW4gY2xhaW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDhdLCJlcnJvck1lc3NhZ2UiOiJzaGFyZSBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2LDMxM10sImVycm9yTWVzc2FnZSI6InRvdGFsIHNoYXJlcyBleGNlZWQgMTAwJSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOV0sImVycm9yTWVzc2FnZSI6IndpbGwgaGFzIG5vdCByZWFjaGVkIHJlbGVhc2UgY29uZGl0aW9ucyB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlZbVZ1WldacFkybGhjbmxmWTI5MWJuUWlJQ0p2ZDI1bGNpSWdJbTFoYm5WaGJGOXlaV3hsWVhObElpQXdlREF3SUNKeVpXeGxZWE5sWDJSaGRHVWlJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklHTnNZWE56SUVScFoybDBZV3hYYVd4c0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROVFV4WldVMU4ySWdNSGhqWm1FeU9ESmlOU0F3ZURabE1tVmlZemxpSURCNFpqTTNPR1kwTnpjZ01IZ3paREZrTW1Zd1ppQXdlRGcxTlRSaU1qY3hJREI0TnpJek16Qm1aVGNnTHk4Z2JXVjBhRzlrSUNKaFpHUmZZbVZ1WldacFkybGhjbmtvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDJKbGJtVm1hV05wWVhKNUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEhKcFoyZGxjbDl0WVc1MVlXeGZjbVZzWldGelpTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeGhhVzBvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjlpWlc1bFptbGphV0Z5ZVNoMWFXNTBOalFwS0dGa1pISmxjM01zZFdsdWREWTBMR0p2YjJ3cElpd2diV1YwYUc5a0lDSm5aWFJmZDJsc2JGOXpkR0YwZFhNb0tTaGhaR1J5WlhOekxIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5Da2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JoWkdSZlltVnVaV1pwWTJsaGNua2dkWEJrWVhSbFgySmxibVZtYVdOcFlYSjVJR1JsY0c5emFYUWdkSEpwWjJkbGNsOXRZVzUxWVd4ZmNtVnNaV0Z6WlNCamJHRnBiU0JuWlhSZlltVnVaV1pwWTJsaGNua2daMlYwWDNkcGJHeGZjM1JoZEhWekNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCamJHRnpjeUJFYVdkcGRHRnNWMmxzYkNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF3WkRKbU5qY2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FXZHBkR0ZzWDNkcGJHd3VZMjl1ZEhKaFkzUXVSR2xuYVhSaGJGZHBiR3d1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJ6Wld4bUxtOTNibVZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNXlaV3hsWVhObFgyUmhkR1V1ZG1Gc2RXVWdQU0J5Wld4bFlYTmxYMlJoZEdVdWJtRjBhWFpsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5Wld4bFlYTmxYMlJoZEdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnYzJWc1ppNXRZVzUxWVd4ZmNtVnNaV0Z6WlM1MllXeDFaU0E5SUVaaGJITmxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnRZVzUxWVd4ZmNtVnNaV0Z6WlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1aVpXNWxabWxqYVdGeWVWOWpiM1Z1ZEM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1WdVpXWnBZMmxoY25sZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWthV2RwZEdGc1gzZHBiR3d1WTI5dWRISmhZM1F1UkdsbmFYUmhiRmRwYkd3dVlXUmtYMkpsYm1WbWFXTnBZWEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYMkpsYm1WbWFXTnBZWEo1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNkdVpYSXVkbUZzZFdVc0lDSnZibXg1SUc5M2JtVnlJR05oYmlCaFpHUWdZbVZ1WldacFkybGhjbWxsY3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0J2ZDI1bGNpQmpZVzRnWVdSa0lHSmxibVZtYVdOcFlYSnBaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUpsYm1WbWFXTnBZWEo1WDJOdmRXNTBMblpoYkhWbElEd2dWVWx1ZERZMEtFMUJXRjlDUlU1RlJrbERTVUZTU1VWVEtTd2dJbTFoZUNCaVpXNWxabWxqYVdGeWFXVnpJSEpsWVdOb1pXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltVnVaV1pwWTJsaGNubGZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbVZ1WldacFkybGhjbmxmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCdFlYZ2dZbVZ1WldacFkybGhjbWxsY3lCeVpXRmphR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QmhjM05sY25RZ2MyaGhjbVZmY0dWeVkyVnVkQzV1WVhScGRtVWdQaUJWU1c1ME5qUW9NQ2tzSUNKemFHRnlaU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZJZ29nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCemFHRnlaU0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlCNlpYSnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZkRzkwWVd4ZmMyaGhjbVZ6S0NrZ0t5QnphR0Z5WlY5d1pYSmpaVzUwTG01aGRHbDJaU0E4UFNCVlNXNTBOalFvTVRBd0tTd2dJblJ2ZEdGc0lITm9ZWEpsY3lCbGVHTmxaV1FnTVRBd0pTSUtJQ0FnSUdOaGJHeHpkV0lnWDNSdmRHRnNYM05vWVhKbGN3b2dJQ0FnS3dvZ0lDQWdjSFZ6YUdsdWRDQXhNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2RHOTBZV3dnYzJoaGNtVnpJR1Y0WTJWbFpDQXhNREFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnpiRzkwSUQwZ2MyVnNaaTVmWjJWMFgzTnNiM1FvYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWlc1bFptbGphV0Z5ZVY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVpXNWxabWxqYVdGeWVWOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRjl6Ykc5MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPalkyTFRjd0NpQWdJQ0F2THlCemJHOTBMblpoYkhWbElEMGdRbVZ1WldacFkybGhjbmtvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxaFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lITm9ZWEpsWDNCbGNtTmxiblE5YzJoaGNtVmZjR1Z5WTJWdWRDd0tJQ0FnSUM4dklDQWdJQ0JqYkdGcGJXVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJR05zWVdsdFpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvMk5pMDNNQW9nSUNBZ0x5OGdjMnh2ZEM1MllXeDFaU0E5SUVKbGJtVm1hV05wWVhKNUtBb2dJQ0FnTHk4Z0lDQWdJR0ZrWkhKbGMzTTlZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J6YUdGeVpWOXdaWEpqWlc1MFBYTm9ZWEpsWDNCbGNtTmxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFsWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDNTJZV3gxWlNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaVpXNWxabWxqYVdGeWVWOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlaVzVsWm1samFXRnllVjlqYjNWdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbG5hWFJoYkY5M2FXeHNMbU52Ym5SeVlXTjBMa1JwWjJsMFlXeFhhV3hzTG5Wd1pHRjBaVjlpWlc1bFptbGphV0Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlY5aVpXNWxabWxqYVdGeWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG8zTndvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlN3Z0ltOXViSGtnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0JpWlc1bFptbGphV0Z5YVdWeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUc5M2JtVnlJR05oYmlCMWNHUmhkR1VnWW1WdVpXWnBZMmxoY21sbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnYVdSNElEMGdhVzVrWlhndWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QmhjM05sY25RZ2FXUjRJRHdnYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDNTJZV3gxWlN3Z0ltbHVkbUZzYVdRZ1ltVnVaV1pwWTJsaGNua2dhVzVrWlhnaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1WdVpXWnBZMmxoY25sZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltVnVaV1pwWTJsaGNubGZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ1ltVnVaV1pwWTJsaGNua2dhVzVrWlhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJSE5zYjNRZ1BTQnpaV3htTGw5blpYUmZjMnh2ZENocFpIZ3BDaUFnSUNCallXeHNjM1ZpSUY5blpYUmZjMnh2ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdZM1Z5Y21WdWRDQTlJSE5zYjNRdWRtRnNkV1V1WTI5d2VTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdOMWNuSmxiblF1WTJ4aGFXMWxaQzV1WVhScGRtVXNJQ0pqWVc1dWIzUWdaV1JwZENCaElHSmxibVZtYVdOcFlYSjVJSGRvYnlCaGJISmxZV1I1SUdOc1lXbHRaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016SXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc1dWIzUWdaV1JwZENCaElHSmxibVZtYVdOcFlYSjVJSGRvYnlCaGJISmxZV1I1SUdOc1lXbHRaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklISmxiV0ZwYm1sdVoxOTBiM1JoYkNBOUlITmxiR1l1WDNSdmRHRnNYM05vWVhKbGN5Z3BJQzBnWTNWeWNtVnVkQzV6YUdGeVpWOXdaWEpqWlc1MExtNWhkR2wyWlFvZ0lDQWdZMkZzYkhOMVlpQmZkRzkwWVd4ZmMyaGhjbVZ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGJXRnBibWx1WjE5MGIzUmhiQ0FySUhOb1lYSmxYM0JsY21ObGJuUXVibUYwYVhabElEdzlJRlZKYm5RMk5DZ3hNREFwTENBaWRHOTBZV3dnYzJoaGNtVnpJR1Y0WTJWbFpDQXhNREFsSWdvZ0lDQWdaR2xuSURRS0lDQWdJR0owYjJrS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ01UQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSdmRHRnNJSE5vWVhKbGN5QmxlR05sWldRZ01UQXdKUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z1lXUmtjbVZ6Y3oxamRYSnlaVzUwTG1Ga1pISmxjM01zQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk9EZ3RPVElLSUNBZ0lDOHZJSE5zYjNRdWRtRnNkV1VnUFNCQ1pXNWxabWxqYVdGeWVTZ0tJQ0FnSUM4dklDQWdJQ0JoWkdSeVpYTnpQV04xY25KbGJuUXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J6YUdGeVpWOXdaWEpqWlc1MFBYTm9ZWEpsWDNCbGNtTmxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFsWkQxamRYSnlaVzUwTG1Oc1lXbHRaV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJwWjJsMFlXeGZkMmxzYkM1amIyNTBjbUZqZEM1RWFXZHBkR0ZzVjJsc2JDNWtaWEJ2YzJsMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1Z3YjNOcGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlN3Z0ltOXViSGtnYjNkdVpYSWdZMkZ1SUdaMWJtUWdkR2hsSUhkcGJHd2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ2IzZHVaWElnWTJGdUlHWjFibVFnZEdobElIZHBiR3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2xuYVhSaGJGOTNhV3hzTG1OdmJuUnlZV04wTGtScFoybDBZV3hYYVd4c0xuUnlhV2RuWlhKZmJXRnVkV0ZzWDNKbGJHVmhjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtbG5aMlZ5WDIxaGJuVmhiRjl5Wld4bFlYTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0p2Ym14NUlHOTNibVZ5SUdOaGJpQjBjbWxuWjJWeUlHMWhiblZoYkNCeVpXeGxZWE5sSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJRzkzYm1WeUlHTmhiaUIwY21sbloyVnlJRzFoYm5WaGJDQnlaV3hsWVhObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnYzJWc1ppNXRZVzUxWVd4ZmNtVnNaV0Z6WlM1MllXeDFaU0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltMWhiblZoYkY5eVpXeGxZWE5sSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJwWjJsMFlXeGZkMmxzYkM1amIyNTBjbUZqZEM1RWFXZHBkR0ZzVjJsc2JDNWpiR0ZwYlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNZV2x0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHbGtlQ0E5SUdsdVpHVjRMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0JwWkhnZ1BDQnpaV3htTG1KbGJtVm1hV05wWVhKNVgyTnZkVzUwTG5aaGJIVmxMQ0FpYVc1MllXeHBaQ0JpWlc1bFptbGphV0Z5ZVNCcGJtUmxlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlaVzVsWm1samFXRnllVjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpWlc1bFptbGphV0Z5ZVY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0JpWlc1bFptbGphV0Z5ZVNCcGJtUmxlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklITnNiM1FnUFNCelpXeG1MbDluWlhSZmMyeHZkQ2hwWkhncENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZmMyeHZkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeE9Rb2dJQ0FnTHk4Z1ltVnVaV1pwWTJsaGNua2dQU0J6Ykc5MExuWmhiSFZsTG1OdmNIa29LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJR0psYm1WbWFXTnBZWEo1TG1Ga1pISmxjM011Ym1GMGFYWmxMQ0FpYjI1c2VTQjBhR1VnYm1GdFpXUWdZbVZ1WldacFkybGhjbmtnWTJGdUlHTnNZV2x0SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnZEdobElHNWhiV1ZrSUdKbGJtVm1hV05wWVhKNUlHTmhiaUJqYkdGcGJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1ltVnVaV1pwWTJsaGNua3VZMnhoYVcxbFpDNXVZWFJwZG1Vc0lDSmhiSEpsWVdSNUlHTnNZV2x0WldRaUNpQWdJQ0J3ZFhOb2FXNTBJRE15TUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ1kyeGhhVzFsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSE5sYkdZdWNtVnNaV0Z6WlY5a1lYUmxMblpoYkhWbENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpY21Wc1pXRnpaVjlrWVhSbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsYkdWaGMyVmZaR0YwWlNCbGVHbHpkSE1LSUNBZ0lENDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeU5TMHhNallLSUNBZ0lDOHZJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSE5sYkdZdWNtVnNaV0Z6WlY5a1lYUmxMblpoYkhWbENpQWdJQ0F2THlCdmNpQnpaV3htTG0xaGJuVmhiRjl5Wld4bFlYTmxMblpoYkhWbENpQWdJQ0JpYm5vZ1kyeGhhVzFmWW05dmJGOTBjblZsUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJ2Y2lCelpXeG1MbTFoYm5WaGJGOXlaV3hsWVhObExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWliV0Z1ZFdGc1gzSmxiR1ZoYzJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0Z1ZFdGc1gzSmxiR1ZoYzJVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXlOUzB4TWpZS0lDQWdJQzh2SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDQ5SUhObGJHWXVjbVZzWldGelpWOWtZWFJsTG5aaGJIVmxDaUFnSUNBdkx5QnZjaUJ6Wld4bUxtMWhiblZoYkY5eVpXeGxZWE5sTG5aaGJIVmxDaUFnSUNCaWVpQmpiR0ZwYlY5aWIyOXNYMlpoYkhObFFEUUtDbU5zWVdsdFgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbU5zWVdsdFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk1USTRDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnNaV0Z6WlY5eVpXRmtlU3dnSW5kcGJHd2dhR0Z6SUc1dmRDQnlaV0ZqYUdWa0lISmxiR1ZoYzJVZ1kyOXVaR2wwYVc5dWN5QjVaWFFpQ2lBZ0lDQmhjM05sY25RZ0x5OGdkMmxzYkNCb1lYTWdibTkwSUhKbFlXTm9aV1FnY21Wc1pXRnpaU0JqYjI1a2FYUnBiMjV6SUhsbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG94TXpBS0lDQWdJQzh2SUdOdmJuUnlZV04wWDJKaGJHRnVZMlVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG1KaGJHRnVZMlVLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE16RUtJQ0FnSUM4dklIQmhlVzkxZEY5aGJXOTFiblFnUFNBb1kyOXVkSEpoWTNSZlltRnNZVzVqWlNBcUlHSmxibVZtYVdOcFlYSjVMbk5vWVhKbFgzQmxjbU5sYm5RdWJtRjBhWFpsS1NBdkx5QlZTVzUwTmpRb01UQXdLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBek1pQTRDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01UQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPakV6TXkweE16Y0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxaVpXNWxabWxqYVdGeWVTNWhaR1J5WlhOekxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNHRjViM1YwWDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPakV6TmdvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG94TXpNdE1UTTNDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVltVnVaV1pwWTJsaGNua3VZV1JrY21WemN5NXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQmhlVzkxZEY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5M2FXeHNMMk52Ym5SeVlXTjBMbkI1T2pFek9TMHhORE1LSUNBZ0lDOHZJSE5zYjNRdWRtRnNkV1VnUFNCQ1pXNWxabWxqYVdGeWVTZ0tJQ0FnSUM4dklDQWdJQ0JoWkdSeVpYTnpQV0psYm1WbWFXTnBZWEo1TG1Ga1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZmY0dWeVkyVnVkRDFpWlc1bFptbGphV0Z5ZVM1emFHRnlaVjl3WlhKalpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lXbHRaV1E5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdZMnhoYVcxbFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG94TXprdE1UUXpDaUFnSUNBdkx5QnpiRzkwTG5aaGJIVmxJRDBnUW1WdVpXWnBZMmxoY25rb0NpQWdJQ0F2THlBZ0lDQWdZV1JrY21WemN6MWlaVzVsWm1samFXRnllUzVoWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhOb1lYSmxYM0JsY21ObGJuUTlZbVZ1WldacFkybGhjbmt1YzJoaGNtVmZjR1Z5WTJWdWRDd0tJQ0FnSUM4dklDQWdJQ0JqYkdGcGJXVmtQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpiR0ZwYlY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCamJHRnBiVjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2xuYVhSaGJGOTNhV3hzTG1OdmJuUnlZV04wTGtScFoybDBZV3hYYVd4c0xtZGxkRjlpWlc1bFptbGphV0Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlpWlc1bFptbGphV0Z5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCcFpIZ2dQU0JwYm1SbGVDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdhV1I0SUR3Z2MyVnNaaTVpWlc1bFptbGphV0Z5ZVY5amIzVnVkQzUyWVd4MVpTd2dJbWx1ZG1Gc2FXUWdZbVZ1WldacFkybGhjbmtnYVc1a1pYZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltVnVaV1pwWTJsaGNubGZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbVZ1WldacFkybGhjbmxmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdZbVZ1WldacFkybGhjbmtnYVc1a1pYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRRNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWZaMlYwWDNOc2IzUW9hV1I0S1M1MllXeDFaUW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYM05zYjNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FXZHBkR0ZzWDNkcGJHd3VZMjl1ZEhKaFkzUXVSR2xuYVhSaGJGZHBiR3d1WjJWMFgzZHBiR3hmYzNSaGRIVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzZHBiR3hmYzNSaGRIVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklHRnlZelF1UVdSa2NtVnpjeWh6Wld4bUxtOTNibVZ5TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuSmxiR1ZoYzJWZlpHRjBaUzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNtVnNaV0Z6WlY5a1lYUmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGJHVmhjMlZmWkdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFUzQ2lBZ0lDQXZMeUJoY21NMExrSnZiMndvYzJWc1ppNXRZVzUxWVd4ZmNtVnNaV0Z6WlM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWliV0Z1ZFdGc1gzSmxiR1ZoYzJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0Z1ZFdGc1gzSmxiR1ZoYzJVZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdVltVnVaV1pwWTJsaGNubGZZMjkxYm5RdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpsYm1WbWFXTnBZWEo1WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KbGJtVm1hV05wWVhKNVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRveE5UTXRNVFl3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVRV1JrY21WemN5aHpaV3htTG05M2JtVnlMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpXeGxZWE5sWDJSaGRHVXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMa0p2YjJ3b2MyVnNaaTV0WVc1MVlXeGZjbVZzWldGelpTNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WW1WdVpXWnBZMmxoY25sZlkyOTFiblF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsbmFYUmhiRjkzYVd4c0xtTnZiblJ5WVdOMExrUnBaMmwwWVd4WGFXeHNMbDluWlhSZmMyeHZkQ2hwYm1SbGVEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tYMmRsZEY5emJHOTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z1pHVm1JRjluWlhSZmMyeHZkQ2h6Wld4bUxDQnBibVJsZURvZ1ZVbHVkRFkwS1NBdFBpQkhiRzlpWVd4VGRHRjBaVnRDWlc1bFptbGphV0Z5ZVYwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCcGJtUmxlQ0E4SUZWSmJuUTJOQ2hOUVZoZlFrVk9SVVpKUTBsQlVrbEZVeWtzSUNKcGJuWmhiR2xrSUhOc2IzUWdhVzVrWlhnaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYzJ4dmRDQnBibVJsZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdhV1lnYVc1a1pYZ2dQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlibm9nWDJkbGRGOXpiRzkwWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aVpXNWxabWxqYVdGeWVWOHdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltSmxibVZtYVdOcFlYSjVYekFpQ2lBZ0lDQnlaWFJ6ZFdJS0NsOW5aWFJmYzJ4dmRGOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklHVnNhV1lnYVc1a1pYZ2dQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklGOW5aWFJmYzJ4dmRGOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbVZ1WldacFkybGhjbmxmTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppWlc1bFptbGphV0Z5ZVY4eElnb2dJQ0FnY21WMGMzVmlDZ3BmWjJWMFgzTnNiM1JmWld4elpWOWliMlI1UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJsYkdsbUlHbHVaR1Y0SUQwOUlGVkpiblEyTkNneUtUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dYMmRsZEY5emJHOTBYMlZzYzJWZlltOWtlVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpWlc1bFptbGphV0Z5ZVY4eUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1KbGJtVm1hV05wWVhKNVh6SWlDaUFnSUNCeVpYUnpkV0lLQ2w5blpYUmZjMnh2ZEY5bGJITmxYMkp2WkhsQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUdWc2FXWWdhVzVrWlhnZ1BUMGdWVWx1ZERZMEtETXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWjJWMFgzTnNiM1JmWld4elpWOWliMlI1UURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KbGJtVm1hV05wWVhKNVh6TUtJQ0FnSUhCMWMyaGllWFJsY3lBaVltVnVaV1pwWTJsaGNubGZNeUlLSUNBZ0lISmxkSE4xWWdvS1gyZGxkRjl6Ykc5MFgyVnNjMlZmWW05a2VVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmQybHNiQzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbVZ1WldacFkybGhjbmxmTkFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppWlc1bFptbGphV0Z5ZVY4MElnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ScFoybDBZV3hmZDJsc2JDNWpiMjUwY21GamRDNUVhV2RwZEdGc1YybHNiQzVmZEc5MFlXeGZjMmhoY21WektDa2dMVDRnZFdsdWREWTBPZ3BmZEc5MFlXeGZjMmhoY21Wek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWkdWbUlGOTBiM1JoYkY5emFHRnlaWE1vYzJWc1ppa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTUNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjkzYVd4c0wyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUIwYjNSaGJDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDNkcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hOUVZoZlFrVk9SVVpKUTBsQlVrbEZVeWs2Q2lBZ0lDQmtkWEFLQ2w5MGIzUmhiRjl6YUdGeVpYTmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZkMmxzYkM5amIyNTBjbUZqZEM1d2VUbzVOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtFMUJXRjlDUlU1RlJrbERTVUZTU1VWVEtUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEd0tJQ0FnSUdKNklGOTBiM1JoYkY5emFHRnlaWE5mWVdaMFpYSmZabTl5UURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJR2xtSUdrZ1BDQnpaV3htTG1KbGJtVm1hV05wWVhKNVgyTnZkVzUwTG5aaGJIVmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSmxibVZtYVdOcFlYSjVYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUpsYm1WbWFXTnBZWEo1WDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJRDRLSUNBZ0lHSjZJRjkwYjNSaGJGOXphR0Z5WlhOZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOTNhV3hzTDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QnpiRzkwSUQwZ2MyVnNaaTVmWjJWMFgzTnNiM1FvYVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmYzJ4dmRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmZDJsc2JDOWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnZEc5MFlXd2dLejBnYzJ4dmRDNTJZV3gxWlM1emFHRnlaVjl3WlhKalpXNTBMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGZkRzkwWVd4ZmMyaGhjbVZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gzZHBiR3d2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoTlFWaGZRa1ZPUlVaSlEwbEJVa2xGVXlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZmRHOTBZV3hmYzJoaGNtVnpYMlp2Y2w5b1pXRmtaWEpBTVFvS1gzUnZkR0ZzWDNOb1lYSmxjMTloWm5SbGNsOW1iM0pBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYM2RwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkRzkwWVd3S0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUlDWUdFV0psYm1WbWFXTnBZWEo1WDJOdmRXNTBCVzkzYm1WeURtMWhiblZoYkY5eVpXeGxZWE5sQVFBTWNtVnNaV0Z6WlY5a1lYUmxCQlVmZkhVeEdSUkVNUmhCQURtQ0J3UlZIdVY3Qk0raWdyVUViaTY4bXdUemVQUjNCRDBkTHc4RWhWU3ljUVJ5TXcvbk5ob0FqZ2NBS0FCc0FNRUEwZ0RmQVZ3QmV3Q0FCQ1FOTDJjMkdnQ09BUUFCQURZYUFVa1ZKQkpFS1RFQVp4Y25CRXhuS2lKbktDSm5JME0yR2dGSkZTVVNSRFlhQWtrVkpCSkVNUUFpS1dWRUVrUWlLR1ZFZ1FVTVJFa1hTVVNJQWNvSWdXUU9SQ0lvWlVTSUFVbE9BbEFyVUdjaUtHVkVJd2dvVEdjalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtReEFDSXBaVVFTUkV3WElpaGxSRXNCRFVTSUFSTWlTd0ZsUkVtQndBSlRLeUpQQWxSSklsTVVSSWdCY1VzQ0pWc0pTd1FYQ0lGa0RrUk1Wd0FnVHdOUVRGQm5JME0yR2dFVkpCSkVNUUFpS1dWRUVrUWpRekVBSWlsbFJCSkVLaU5uSTBNMkdnRkpGU1FTUkJjaUtHVkVTd0VOUklnQXNVa2lUR1ZNU1U4Q1JERUFTd0ZYQUNCSlRnTVNSSUhBQWxNcklrOENWQ0pURkVReUJ5SW5CR1ZFRDBBQUJ5SXFaVVJCQURFalJESUtjd0JFU3dKSlZ5QUlUQ1ZiVHdJTGdXUUtzYklJU3dGSnNnY2pzaEFpc2dHelRGQ0FBWUJRU3dOTVp5TkRJa0wvekRZYUFVa1ZKQkpFRnlJb1pVUkxBUTFFaUFBMElreGxSQ2NGVEZDd0kwTWlLV1ZFSWljRVpVUVdJaXBsUkNzaVR3SlVJaWhsUkJaUEEwOERVRThDVUV4UUp3Vk1VTEFqUTRvQkFZdi9nUVVNUkl2L1FBQVFnQTFpWlc1bFptbGphV0Z5ZVY4d2lZdi9JeEpCQUJDQURXSmxibVZtYVdOcFlYSjVYekdKaS8rQkFoSkJBQkNBRFdKbGJtVm1hV05wWVhKNVh6S0ppLytCQXhKQkFCQ0FEV0psYm1WbWFXTnBZWEo1WHpPSmdBMWlaVzVsWm1samFXRnllVjgwaVlvQUFTSkppd0dCQlF4QkFDTWlLR1ZFaXdFTlFRQVFpd0dJLzI4aVRHVkVKVnVMQUFpTUFJc0JJd2lNQVVMLzFZaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
