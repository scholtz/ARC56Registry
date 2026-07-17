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

namespace Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.CommunityDonationHub_d749f83b
{


    public class CommunityDonationHubProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CommunityDonationHubProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetAppealReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetAppealReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetAppealReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetAppealReturn);
                }
                public bool Equals(GetAppealReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetAppealReturn left, GetAppealReturn right)
                {
                    return EqualityComparer<GetAppealReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetAppealReturn left, GetAppealReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class DonatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 212, 77, 181, 117 };
                public const string Signature = "Donated(uint64,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppealId { get; set; }
                public ulong AmountMicro { get; set; }
                public Algorand.Address Donor { get; set; }

                public static DonatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DonatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppealId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppealId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppealId = vAppealId.ToValue();
                    if (valueAppealId is ulong vAppealIdValue) { ret.AppealId = vAppealIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountMicro.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountMicro = vAmountMicro.ToValue();
                    if (valueAmountMicro is ulong vAmountMicroValue) { ret.AmountMicro = vAmountMicroValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDonor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDonor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDonor = vDonor.ToValue();
                    if (valueDonor is Algorand.Address vDonorValue) { ret.Donor = vDonorValue; }
                    return ret;

                }

            }

            public class WithdrawnEvent
            {
                public static readonly byte[] Selector = new byte[4] { 159, 225, 161, 19 };
                public const string Signature = "Withdrawn(uint64,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppealId { get; set; }
                public ulong AmountMicro { get; set; }
                public Algorand.Address Beneficiary { get; set; }

                public static WithdrawnEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawnEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppealId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppealId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppealId = vAppealId.ToValue();
                    if (valueAppealId is ulong vAppealIdValue) { ret.AppealId = vAppealIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountMicro.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountMicro = vAmountMicro.ToValue();
                    if (valueAmountMicro is ulong vAmountMicroValue) { ret.AmountMicro = vAmountMicroValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBeneficiary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBeneficiary = vBeneficiary.ToValue();
                    if (valueBeneficiary is Algorand.Address vBeneficiaryValue) { ret.Beneficiary = vBeneficiaryValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task Bootstrap(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 241, 78, 163 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 241, 78, 163 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="beneficiary"> </param>
        /// <param name="metadata_uri"> </param>
        public async Task<ulong> CreateAppeal(ulong target, Algorand.Address beneficiary, string metadata_uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 44, 99, 204 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var metadata_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_uriAbi.From(metadata_uri);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, beneficiaryAbi, metadata_uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateAppeal_Transactions(ulong target, Algorand.Address beneficiary, string metadata_uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 44, 99, 204 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var metadata_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_uriAbi.From(metadata_uri);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, beneficiaryAbi, metadata_uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appeal_id"> </param>
        public async Task AdminApprove(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 42, 115, 73 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            var result = await base.CallApp(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminApprove_Transactions(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 42, 115, 73 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appeal_id"> </param>
        /// <param name="payment"> </param>
        public async Task Donate(PaymentTransaction payment, ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 177, 176, 115, 205 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            var result = await base.CallApp(new List<object> { abiHandle, appeal_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Donate_Transactions(PaymentTransaction payment, ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 177, 176, 115, 205 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, appeal_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appeal_id"> </param>
        public async Task Withdraw(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            var result = await base.CallApp(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appeal_id"> </param>
        public async Task<Structs.GetAppealReturn> GetAppeal(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 20, 146, 243 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            var result = await base.SimApp(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetAppealReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAppeal_Transactions(ulong appeal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 20, 146, 243 };
            var appeal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appeal_idAbi.From(appeal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, appeal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29tbXVuaXR5RG9uYXRpb25IdWIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0QXBwZWFsUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX2FwcGVhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YWRhdGFfdXJpIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRtaW5fYXBwcm92ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBlYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZG9uYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGVhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRG9uYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBlYWxfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfbWljcm8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9ub3IiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBlYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IldpdGhkcmF3biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBlYWxfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfbWljcm8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZpY2lhcnkiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXBwZWFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGVhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0QXBwZWFsUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyOCwyMjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYXBwZWFsX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQsMTU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NiwyMjMsMjYwLDMzNSw0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBeE1qZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRmtiV2x1SWlBaVlYQndaV0ZzWDJOdmRXNTBJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z2MyVnNaaTVoY0hCbFlXeGZZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poY0hCbFlXeGZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVW9RVkpETkVGa1pISmxjM01vS1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXRiWFZ1YVhSNVJHOXVZWFJwYjI1SWRXSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTFDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaG1NMll4TkdWaE15QXdlRE0xTW1NMk0yTmpJREI0TW1VeVlUY3pORGtnTUhoaU1XSXdOek5qWkNBd2VESXhaakZrWkdabUlEQjRaakV4TkRreVpqTWdMeThnYldWMGFHOWtJQ0ppYjI5MGMzUnlZWEFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWZllYQndaV0ZzS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSE4wY21sdVp5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltRmtiV2x1WDJGd2NISnZkbVVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUnZibUYwWlNoMWFXNTBOalFzY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWVhCd1pXRnNLSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0lHTnlaV0YwWlY5aGNIQmxZV3dnWVdSdGFXNWZZWEJ3Y205MlpTQmtiMjVoZEdVZ2QybDBhR1J5WVhjZ1oyVjBYMkZ3Y0dWaGJBb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUxT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkQzVEYjIxdGRXNXBkSGxFYjI1aGRHbHZia2gxWWk1aWIyOTBjM1J5WVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliMjkwYzNSeVlYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1Ga2JXbHVMblpoYkhWbExtSjVkR1Z6SUQwOUlHOXdMbUo2WlhKdktETXlLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXRkVzVwZEhsZlpHOXVZWFJwYjI1ZmFIVmlMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXRkVzVwZEhsZlpHOXVZWFJwYjI1ZmFIVmlMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1F1UTI5dGJYVnVhWFI1Ukc5dVlYUnBiMjVJZFdJdVkzSmxZWFJsWDJGd2NHVmhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjloY0hCbFlXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklHRnBaQ0E5SUhObGJHWXVZWEJ3WldGc1gyTnZkVzUwTG5aaGJIVmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWEJ3WldGc1gyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjR1ZoYkY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdjMlZzWmk1aGNIQmxZV3hmWTI5MWJuUXVkbUZzZFdVZ1BTQmhhV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZ3Y0dWaGJGOWpiM1Z1ZENJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUdKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YjNBdWFYUnZZaWhoYVdRcEtRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUdKdmVDNWpjbVZoZEdVb2MybDZaVDFDVDFoZlUwbGFSU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERXlPQW9nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnWW5WbUlEMGdiM0F1WW5wbGNtOG9RazlZWDFOSldrVXBDaUFnSUNCcGJuUmpYek1nTHk4Z01USTRDaUFnSUNCaWVtVnlid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHSjFaaUE5SUc5d0xuSmxjR3hoWTJVb1luVm1MQ0F3TENCdmNDNXBkRzlpS0hSaGNtZGxkQzV1WVhScGRtVXBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdZblZtSUQwZ2IzQXVjbVZ3YkdGalpTaGlkV1lzSURnc0lHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY21Wd2JHRmpaVElnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR0oxWmlBOUlHOXdMbkpsY0d4aFkyVW9ZblZtTENBeE5pd2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXRkVzVwZEhsZlpHOXVZWFJwYjI1ZmFIVmlMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCaWRXWWdQU0J2Y0M1eVpYQnNZV05sS0dKMVppd2dNalFzSUdKbGJtVm1hV05wWVhKNUxtSjVkR1Z6S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTWlBeU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUdKdmVDNXdkWFFvWW5WbUtRb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF0ZFc1cGRIbGZaRzl1WVhScGIyNWZhSFZpTDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVEyOXRiWFZ1YVhSNVJHOXVZWFJwYjI1SWRXSXVZV1J0YVc1ZllYQndjbTkyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtiV2x1WDJGd2NISnZkbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXVZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF0ZFc1cGRIbGZaRzl1WVhScGIyNWZhSFZpTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXOXdMbWwwYjJJb1lYQndaV0ZzWDJsa0xtNWhkR2wyWlNrcENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnWkdWbVlYVnNkQ0E5SUc5d0xtSjZaWEp2S0VKUFdGOVRTVnBGS1FvZ0lDQWdhVzUwWTE4eklDOHZJREV5T0FvZ0lDQWdZbnBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJpZFdZZ1BTQmliM2d1WjJWMEtHUmxabUYxYkhROVpHVm1ZWFZzZENrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF0ZFc1cGRIbGZaRzl1WVhScGIyNWZhSFZpTDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9ZblZtTENBeE5pd2dPQ2twQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhOMFlYUjFjeUE5UFNCVlNXNTBOalFvTUNrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJR0oxWmlBOUlHOXdMbkpsY0d4aFkyVW9ZblZtTENBeE5pd2diM0F1YVhSdllpaFZTVzUwTmpRb01Ta3BLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnWW05NExuQjFkQ2hpZFdZcENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtOdmJXMTFibWwwZVVSdmJtRjBhVzl1U0hWaUxtUnZibUYwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUnZibUYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF0ZFc1cGRIbGZaRzl1WVhScGIyNWZhSFZpTDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TnpRS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklHSnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWIzQXVhWFJ2WWloaGNIQmxZV3hmYVdRdWJtRjBhWFpsS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG8zTmdvZ0lDQWdMeThnWkdWbVlYVnNkQ0E5SUc5d0xtSjZaWEp2S0VKUFdGOVRTVnBGS1FvZ0lDQWdhVzUwWTE4eklDOHZJREV5T0FvZ0lDQWdZbnBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJpZFdZZ1BTQmliM2d1WjJWMEtHUmxabUYxYkhROVpHVm1ZWFZzZENrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF0ZFc1cGRIbGZaRzl1WVhScGIyNWZhSFZpTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9ZblZtTENBeE5pd2dPQ2twQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMFlYUjFjeUE5UFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdjbUZwYzJWa0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLR0oxWml3Z09Dd2dPQ2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklISmhhWE5sWkNBOUlISmhhWE5sWkNBcklIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHSjFaaUE5SUc5d0xuSmxjR3hoWTJVb1luVm1MQ0E0TENCdmNDNXBkRzlpS0hKaGFYTmxaQ2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1ltOTRMbkIxZENoaWRXWXBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdZVzF2ZFc1MFgyMXBZM0p2UFVGU1F6UlZTVzUwTmpRb2NHRjViV1Z1ZEM1aGJXOTFiblFwTEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZPRGdLSUNBZ0lDOHZJR1J2Ym05eVBVRlNRelJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9EVXRPRGtLSUNBZ0lDOHZJRVJ2Ym1GMFpXUW9DaUFnSUNBdkx5QWdJQ0FnWVhCd1pXRnNYMmxrUFdGd2NHVmhiRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmJXbGpjbTg5UVZKRE5GVkpiblEyTkNod1lYbHRaVzUwTG1GdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHOXViM0k5UVZKRE5FRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2T0RRdE9UQUtJQ0FnSUM4dklHVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ1JHOXVZWFJsWkNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhCd1pXRnNYMmxrUFdGd2NHVmhiRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVcxdmRXNTBYMjFwWTNKdlBVRlNRelJWU1c1ME5qUW9jR0Y1YldWdWRDNWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCa2IyNXZjajFCVWtNMFFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTkRSa1lqVTNOU0F2THlCdFpYUm9iMlFnSWtSdmJtRjBaV1FvZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtOdmJXMTFibWwwZVVSdmJtRjBhVzl1U0hWaUxuZHBkR2hrY21GM1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklHSnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWIzQXVhWFJ2WWloaGNIQmxZV3hmYVdRdWJtRjBhWFpsS1NrS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJR1JsWm1GMWJIUWdQU0J2Y0M1aWVtVnlieWhDVDFoZlUwbGFSU2tLSUNBZ0lHbHVkR05mTXlBdkx5QXhNamdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUbzVOZ29nSUNBZ0x5OGdZblZtSUQwZ1ltOTRMbWRsZENoa1pXWmhkV3gwUFdSbFptRjFiSFFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtHSjFaaXdnTVRZc0lEZ3BLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUdGemMyVnlkQ0J6ZEdGMGRYTWdQVDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHSmxibVZtYVdOcFlYSjVJRDBnYjNBdVpYaDBjbUZqZENoaWRXWXNJREkwTENBek1pa0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5TkNBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFNCaVpXNWxabWxqYVdGeWVRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnY21GcGMyVmtJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0dKMVppd2dPQ3dnT0NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG94TURJS0lDQWdJQzh2SUdGemMyVnlkQ0J5WVdselpXUWdQaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENoeVpXTmxhWFpsY2oxQlkyTnZkVzUwS0dKbGJtVm1hV05wWVhKNUtTd2dZVzF2ZFc1MFBYSmhhWE5sWkN3Z1ptVmxQVEFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0YlhWdWFYUjVYMlJ2Ym1GMGFXOXVYMmgxWWk5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJR0Z0YjNWdWRGOXRhV055YnoxQlVrTTBWVWx1ZERZMEtISmhhWE5sWkNrc0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG94TURnS0lDQWdJQzh2SUdKbGJtVm1hV05wWVhKNVBVRlNRelJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk1UQTFMVEV3T1FvZ0lDQWdMeThnVjJsMGFHUnlZWGR1S0FvZ0lDQWdMeThnSUNBZ0lHRndjR1ZoYkY5cFpEMWhjSEJsWVd4ZmFXUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMjFwWTNKdlBVRlNRelJWU1c1ME5qUW9jbUZwYzJWa0tTd0tJQ0FnSUM4dklDQWdJQ0JpWlc1bFptbGphV0Z5ZVQxQlVrTTBRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TVRBMExURXhNQW9nSUNBZ0x5OGdaVzFwZENnS0lDQWdJQzh2SUNBZ0lDQlhhWFJvWkhKaGQyNG9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRndjR1ZoYkY5cFpEMWhjSEJsWVd4ZmFXUXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnRiM1Z1ZEY5dGFXTnliejFCVWtNMFZVbHVkRFkwS0hKaGFYTmxaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0psYm1WbWFXTnBZWEo1UFVGU1F6UkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURsbVpURmhNVEV6SUM4dklHMWxkR2h2WkNBaVYybDBhR1J5WVhkdUtIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUJpZFdZZ1BTQnZjQzV5WlhCc1lXTmxLR0oxWml3Z01UWXNJRzl3TG1sMGIySW9WVWx1ZERZMEtESXBLU2tLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPakV4TWdvZ0lDQWdMeThnWW5WbUlEMGdiM0F1Y21Wd2JHRmpaU2hpZFdZc0lEZ3NJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG94TVRNS0lDQWdJQzh2SUdKdmVDNXdkWFFvWW5WbUtRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1RGIyMXRkVzVwZEhsRWIyNWhkR2x2YmtoMVlpNW5aWFJmWVhCd1pXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyRndjR1ZoYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxdGRXNXBkSGxmWkc5dVlYUnBiMjVmYUhWaUwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlcxMWJtbDBlVjlrYjI1aGRHbHZibDlvZFdJdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzl3TG1sMGIySW9ZWEJ3WldGc1gybGtMbTVoZEdsMlpTa3BDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHUmxabUYxYkhRZ1BTQnZjQzVpZW1WeWJ5aENUMWhmVTBsYVJTa0tJQ0FnSUdsdWRHTmZNeUF2THlBeE1qZ0tJQ0FnSUdKNlpYSnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRiWFZ1YVhSNVgyUnZibUYwYVc5dVgyaDFZaTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHSjFaaUE5SUdKdmVDNW5aWFFvWkdWbVlYVnNkRDFrWldaaGRXeDBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGJYVnVhWFI1WDJSdmJtRjBhVzl1WDJoMVlpOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUhSaGNtZGxkQ0E5SUVGU1F6UlZTVzUwTmpRb2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtHSjFaaXdnTUN3Z09Da3BLUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJXMTFibWwwZVY5a2IyNWhkR2x2Ymw5b2RXSXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCeVlXbHpaV1FnUFNCQlVrTTBWVWx1ZERZMEtHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaGlkV1lzSURnc0lEZ3BLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQkJVa00wVlVsdWREWTBLRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2hpZFdZc0lERTJMQ0E0S1NrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01UWWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiVzExYm1sMGVWOWtiMjVoZEdsdmJsOW9kV0l2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJZ0FFbUF3VmhaRzFwYmd4aGNIQmxZV3hmWTI5MWJuUUVGUjk4ZFRFWVFBQUhLU05uS0RJRFp6RWJRUUE1TVJrVVJERVlSSUlHQlBQeFRxTUVOU3hqekFRdUtuTkpCTEd3YzgwRUlmSGQvd1R4RkpMek5ob0FqZ1lBQ1FBZ0FHMEFrZ0RkQVRJQU1Sa1VNUmdVRUVNMkdnRkpGWUVnRWtRaktHVkVnU0N2RWtRb1RHY2lRellhQVVrVkpCSkVOaG9DU1JXQklCSkVOaG9EU1NOWmdRSUlUQlVTUkNNcFpVUWlDQ2xMQVdjV1NTVzVTQ1d2VHdNWEZsd0FJeFpNU3dGY0NFeGNFRThDWEJoTEFVeS9La3hRc0NKRE5ob0JTUlVrRWtReEFDTW9aVVFTUkJjV0phOUxBYjVOU1lFUVd4UkVJaFpjRUw4aVF6WWFBVWtWSkJKRU1SWWlDVWs0RUNJU1JFazRCeklLRWtRNENFbEVTd0VYRmlXdlN3RytUVW1CRUZzaUVrUkpKRnRMQXdnV1hBaS9GakVBVGdKUVRGQ0FCTlJOdFhWTVVMQWlRellhQVVrVkpCSkVTUmNXSmE5TEFiNU5TWUVRV3lJU1JFbFhHQ0F4QUVzQkVrUkxBU1JiU1VTeFNiSUlUTElISXJJUUk3SUJzeFl4QUU4RVR3SlFURkNBQkovaG9STk1VTENCQWhaY0VDTVdYQWkvSWtNMkdnRkpGU1FTUkJjV0phOU12azFKVndBSVN3RlhDQWhQQWxjUUNFNENVRXhRS2t4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJEb25hdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGVhbF9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9taWNybyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkb25vciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiV2l0aGRyYXduIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGVhbF9pZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9taWNybyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
