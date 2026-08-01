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

namespace Arc56.Generated.Ramcharan1706.Trust_Ai.EscrowContract_b2f7a7e4
{


    //
    // Secure escrow contract for AI commerce payments.
    //
    public class EscrowContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EscrowRecord : AVMObjectType
            {
                public string JobId { get; set; }

                public Algorand.Address Payer { get; set; }

                public Algorand.Address Provider { get; set; }

                public ulong Amount { get; set; }

                public string Status { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong ReleasedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vJobId.From(JobId);
                    stringRef[ret.Count] = vJobId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProvider.From(Provider);
                    ret.AddRange(vProvider.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.From(Status);
                    stringRef[ret.Count] = vStatus.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReleasedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReleasedAt.From(ReleasedAt);
                    ret.AddRange(vReleasedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EscrowRecord();
                    uint count = 0;
                    var indexJobId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vJobId.Decode(bytes.Skip(indexJobId + prefixOffset).ToArray());
                    var valueJobId = vJobId.ToValue();
                    if (valueJobId is string vJobIdValue) { ret.JobId = vJobIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProvider.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProvider = vProvider.ToValue();
                    if (valueProvider is Algorand.Address vProviderValue) { ret.Provider = vProviderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    var indexStatus = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.Decode(bytes.Skip(indexStatus + prefixOffset).ToArray());
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is string vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReleasedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReleasedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReleasedAt = vReleasedAt.ToValue();
                    if (valueReleasedAt is ulong vReleasedAtValue) { ret.ReleasedAt = vReleasedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowRecord);
                }
                public bool Equals(EscrowRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowRecord left, EscrowRecord right)
                {
                    return EqualityComparer<EscrowRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowRecord left, EscrowRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the escrow admin and reputation contract id.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="reputation_app_id"> </param>
        public async Task Initialize(Algorand.Address admin, ulong reputation_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 220, 85, 187 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var reputation_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reputation_app_idAbi.From(reputation_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, reputation_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address admin, ulong reputation_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 220, 85, 187 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var reputation_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reputation_app_idAbi.From(reputation_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, reputation_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new escrow for a job.
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="provider"> </param>
        /// <param name="amount"> </param>
        public async Task CreateEscrow(string job_id, Algorand.Address provider, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 67, 85, 152 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, providerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(string job_id, Algorand.Address provider, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 67, 85, 152 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, providerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release escrow funds to the provider and update reputation.
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task ReleasePayment(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 243, 1, 82 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleasePayment_Transactions(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 243, 1, 82 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Refund the escrow amount to the payer.
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task Refund(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 144, 128, 37 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refund_Transactions(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 144, 128, 37 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel an escrow before it is released.
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task Cancel(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 88, 120, 32 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Cancel_Transactions(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 88, 120, 32 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the escrow record for the specified job id.
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task<Structs.EscrowRecord> GetEscrow(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 196, 247, 39 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            var result = await base.SimApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EscrowRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEscrow_Transactions(string job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 196, 247, 39 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjoiU2VjdXJlIGVzY3JvdyBjb250cmFjdCBmb3IgQUkgY29tbWVyY2UgcGF5bWVudHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVzY3Jvd1JlY29yZCI6W3sibmFtZSI6ImpvYl9pZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJwYXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicHJvdmlkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWxlYXNlZF9hdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBlc2Nyb3cgYWRtaW4gYW5kIHJlcHV0YXRpb24gY29udHJhY3QgaWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVwdXRhdGlvbl9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX2VzY3JvdyIsImRlc2MiOiJDcmVhdGUgYSBuZXcgZXNjcm93IGZvciBhIGpvYi4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiam9iX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdmlkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX3BheW1lbnQiLCJkZXNjIjoiUmVsZWFzZSBlc2Nyb3cgZnVuZHMgdG8gdGhlIHByb3ZpZGVyIGFuZCB1cGRhdGUgcmVwdXRhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiam9iX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZCIsImRlc2MiOiJSZWZ1bmQgdGhlIGVzY3JvdyBhbW91bnQgdG8gdGhlIHBheWVyLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkNhbmNlbCBhbiBlc2Nyb3cgYmVmb3JlIGl0IGlzIHJlbGVhc2VkLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2VzY3JvdyIsImRlc2MiOiJSZXR1cm4gdGhlIGVzY3JvdyByZWNvcmQgZm9yIHRoZSBzcGVjaWZpZWQgam9iIGlkLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkVzY3Jvd1JlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg5XSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IGNhbmNlbCBlc2Nyb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTVdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgcmVmdW5kIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzN10sImVycm9yTWVzc2FnZSI6ImNhbm5vdCByZWxlYXNlIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxXSwiZXJyb3JNZXNzYWdlIjoiZHVwbGljYXRlIGpvYiBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NCwyOTksMzc3LDQ1MSw1MjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQsMzA2LDM4NCw0NTgsNTMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MSwxOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwLDIwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgcHJvdmlkZXIgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNCwzOTIsNDY2LDU0MV0sImVycm9yTWVzc2FnZSI6InVua25vd24gZXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExXSwiZXJyb3JNZXNzYWdlIjoiemVybyBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF5SURBZ01TQTNOQW9nSUNBZ1lubDBaV05pYkc5amF5QWlaWE5qY205M2N5SWdNSGd3TURBM05UQTJOVFpsTmpRMk9UWmxOamNnSW1Ga2JXbHVJaUFpY21Wd2RYUmhkR2x2Ymw5aGNIQmZhV1FpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMGdRV1JrY21WemN5Z3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaRzFwYmlJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJSE5sYkdZdWNtVndkWFJoZEdsdmJsOWhjSEJmYVdRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGNIVjBZWFJwYjI1ZllYQndYMmxrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHTnNZWE56SUVWelkzSnZkME52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMlpHUmpOVFZpWWlBd2VEaGxORE0xTlRrNElEQjROakptTXpBeE5USWdNSGd5TURrd09EQXlOU0F3ZUdObE5UZzNPREl3SURCNE16bGpOR1kzTWpjZ0x5OGdiV1YwYUc5a0lDSnBibWwwYVdGc2FYcGxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OeVpXRjBaVjlsYzJOeWIzY29jM1J5YVc1bkxHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYkdWaGMyVmZjR0Y1YldWdWRDaHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbWRXNWtLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKallXNWpaV3dvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjlsYzJOeWIzY29jM1J5YVc1bktTaHpkSEpwYm1jc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnBibWwwYVdGc2FYcGxJR055WldGMFpWOWxjMk55YjNjZ2NtVnNaV0Z6WlY5d1lYbHRaVzUwSUhKbFpuVnVaQ0JqWVc1alpXd2daMlYwWDJWelkzSnZkd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WlhOamNtOTNMbU52Ym5SeVlXTjBMa1Z6WTNKdmQwTnZiblJ5WVdOMExtbHVhWFJwWVd4cGVtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1sMGFXRnNhWHBsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMDlJRUZrWkhKbGMzTW9LU3dnSW1Gc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlHRmtiV2x1Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXpJS0lDQWdJQzh2SUhObGJHWXVjbVZ3ZFhSaGRHbHZibDloY0hCZmFXUXVkbUZzZFdVZ1BTQnlaWEIxZEdGMGFXOXVYMkZ3Y0Y5cFpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVndkWFJoZEdsdmJsOWhjSEJmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSWE5qY205M1EyOXVkSEpoWTNRdVkzSmxZWFJsWDJWelkzSnZkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjlsYzJOeWIzYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z1lYTnpaWEowSUhCeWIzWnBaR1Z5SUNFOUlFRmtaSEpsYzNNb0tTd2dJbWx1ZG1Gc2FXUWdjSEp2ZG1sa1pYSWdZV1JrY21WemN5SUtJQ0FnSUdScFp5QXlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQndjbTkyYVdSbGNpQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaWVtVnlieUJoYlc5MWJuUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2VtVnlieUJoYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCcWIySmZhV1FnYVc0Z2MyVnNaaTVsYzJOeWIzZHpDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxjMk55YjNkeklnb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVmYUdGelgyVnpZM0p2ZHlocWIySmZhV1FwTENBaVpIVndiR2xqWVhSbElHcHZZaUJwWkNJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmtkWEJzYVdOaGRHVWdhbTlpSUdsa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCamNtVmhkR1ZrWDJGMFBVRnlZelJWU1c1ME5qUW9WVWx1ZERZMEtEQXBLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qUXhMVFE1Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JGYzJOeWIzZFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdhbTlpWDJsa1BXcHZZbDlwWkN3S0lDQWdJQzh2SUNBZ0lDQndZWGxsY2oxQlpHUnlaWE56S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2ZG1sa1pYSTljSEp2ZG1sa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVUZ5WXpSVlNXNTBOalFvWVcxdmRXNTBLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05VTNSeWFXNW5LQ0pRWlc1a2FXNW5JaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMUJjbU0wVlVsdWREWTBLRlZKYm5RMk5DZ3dLU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnNaV0Z6WldSZllYUTlRWEpqTkZWSmJuUTJOQ2hWU1c1ME5qUW9NQ2twTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdsdWRDQTVNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0FyQ2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtFRkNUMEZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklITjBZWFIxY3oxVGRISnBibWNvSWxCbGJtUnBibWNpS1N3S0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQTNOVEEyTlRabE5qUTJPVFpsTmpjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TkRFdE5Ea0tJQ0FnSUM4dklISmxZMjl5WkNBOUlFVnpZM0p2ZDFKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCcWIySmZhV1E5YW05aVgybGtMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlQVUZrWkhKbGMzTW9LU3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOTJhV1JsY2oxd2NtOTJhV1JsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVFYSmpORlZKYm5RMk5DaGhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MVRkSEpwYm1jb0lsQmxibVJwYm1jaUtTd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVmtYMkYwUFVGeVl6UlZTVzUwTmpRb1ZVbHVkRFkwS0RBcEtTd0tJQ0FnSUM4dklDQWdJQ0J5Wld4bFlYTmxaRjloZEQxQmNtTTBWVWx1ZERZMEtGVkpiblEyTkNnd0tTa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0cWIySmZhV1JkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSWE5qY205M1EyOXVkSEpoWTNRdWNtVnNaV0Z6WlY5d1lYbHRaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnNaV0Z6WlY5d1lYbHRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjbVYwZFhKdUlHcHZZbDlwWkNCcGJpQnpaV3htTG1WelkzSnZkM01LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ6WTNKdmQzTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDJWelkzSnZkeWhxYjJKZmFXUXBMQ0FpZFc1cmJtOTNiaUJsYzJOeWIzY2lDaUFnSUNCaGMzTmxjblFnTHk4Z2RXNXJibTkzYmlCbGMyTnliM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0cWIySmZhV1JkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVFl0TlRjS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVaWE5qY205M2MxdHFiMkpmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXpkR0YwZFhNZ1BUMGdVM1J5YVc1bktDSlFaVzVrYVc1bklpa3NJQ0pqWVc1dWIzUWdjbVZzWldGelpTQmxjMk55YjNjaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUEzTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlGTjBjbWx1WnlnaVVHVnVaR2x1WnlJcExDQWlZMkZ1Ym05MElISmxiR1ZoYzJVZ1pYTmpjbTkzSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EYzFNRFkxTm1VMk5EWTVObVUyTndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzV1YjNRZ2NtVnNaV0Z6WlNCbGMyTnliM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQlRkSEpwYm1jb0lsSmxiR1ZoYzJWa0lpa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBNE5USTJOVFpqTmpVMk1UY3pOalUyTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCeVpXTnZjbVF1Y21Wc1pXRnpaV1JmWVhRZ1BTQkJjbU0wVlVsdWREWTBLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBNE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZHpXMnB2WWw5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtVnpZM0p2ZHk1amIyNTBjbUZqZEM1RmMyTnliM2REYjI1MGNtRmpkQzV5WldaMWJtUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldaMWJtUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCeVpYUjFjbTRnYW05aVgybGtJR2x1SUhObGJHWXVaWE5qY205M2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTmpjbTkzY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5b1lYTmZaWE5qY205M0tHcHZZbDlwWkNrc0lDSjFibXR1YjNkdUlHVnpZM0p2ZHlJS0lDQWdJR0Z6YzJWeWRDQXZMeUIxYm10dWIzZHVJR1Z6WTNKdmR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVsYzJOeWIzZHpXMnB2WWw5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk5pMDJOd29nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1bGMyTnliM2R6VzJwdllsOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCVGRISnBibWNvSWxCbGJtUnBibWNpS1N3Z0ltTmhibTV2ZENCeVpXWjFibVFnWlhOamNtOTNJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z056UUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JUZEhKcGJtY29JbEJsYm1ScGJtY2lLU3dnSW1OaGJtNXZkQ0J5WldaMWJtUWdaWE5qY205M0lnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNRGMxTURZMU5tVTJORFk1Tm1VMk53b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc1dWIzUWdjbVZtZFc1a0lHVnpZM0p2ZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnY21WamIzSmtMbk4wWVhSMWN5QTlJRk4wY21sdVp5Z2lVbVZtZFc1a1pXUWlLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTNOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EZzFNalkxTmpZM05UWmxOalEyTlRZMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNjMXRxYjJKZmFXUmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWxjMk55YjNjdVkyOXVkSEpoWTNRdVJYTmpjbTkzUTI5dWRISmhZM1F1WTJGdVkyVnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGdVkyVnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdwdllsOXBaQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpZM0p2ZDNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1ZmFHRnpYMlZ6WTNKdmR5aHFiMkpmYVdRcExDQWlkVzVyYm05M2JpQmxjMk55YjNjaUNpQWdJQ0JoYzNObGNuUWdMeThnZFc1cmJtOTNiaUJsYzJOeWIzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRxYjJKZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56VXROellLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0cWIySmZhV1JkTG1OdmNIa29LUW9nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1emRHRjBkWE1nUFQwZ1UzUnlhVzVuS0NKUVpXNWthVzVuSWlrc0lDSmpZVzV1YjNRZ1kyRnVZMlZzSUdWelkzSnZkeUlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEYzBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0RJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbFkyOXlaQzV6ZEdGMGRYTWdQVDBnVTNSeWFXNW5LQ0pRWlc1a2FXNW5JaWtzSUNKallXNXViM1FnWTJGdVkyVnNJR1Z6WTNKdmR5SUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREEzTlRBMk5UWmxOalEyT1RabE5qY0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdWJtOTBJR05oYm1ObGJDQmxjMk55YjNjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGMGRYTWdQU0JUZEhKcGJtY29Ja05oYm1ObGJHeGxaQ0lwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRGMwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdPVFF6TmpFMlpUWXpOalUyWXpaak5qVTJOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJ6Wld4bUxtVnpZM0p2ZDNOYmFtOWlYMmxrWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WlhOamNtOTNMbU52Ym5SeVlXTjBMa1Z6WTNKdmQwTnZiblJ5WVdOMExtZGxkRjlsYzJOeWIzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlpYTmpjbTkzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdwdllsOXBaQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpZM0p2ZDNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1ZmFHRnpYMlZ6WTNKdmR5aHFiMkpmYVdRcExDQWlkVzVyYm05M2JpQmxjMk55YjNjaUNpQWdJQ0JoYzNObGNuUWdMeThnZFc1cmJtOTNiaUJsYzJOeWIzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9EUUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbVZ6WTNKdmQzTmJhbTlpWDJsa1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBZ0FCU2lZRUIyVnpZM0p2ZDNNSkFBZFFaVzVrYVc1bkJXRmtiV2x1RVhKbGNIVjBZWFJwYjI1ZllYQndYMmxrTVJoQUFBY3FNZ05uS3lObk1SdEJBRGt4R1JSRU1SaEVnZ1lFYmR4VnV3U09RMVdZQkdMekFWSUVJSkNBSlFUT1dIZ2dCRG5FOXljMkdnQ09CZ0FKQUMwQXFnRDRBVUlCalFBeEdSUXhHQlFRUXpZYUFVa1ZnU0FTUkRZYUFra1ZnUWdTUkJjakttVkVNZ01TUkNwUEFtY3JUR2NrUXpZYUFVa2pXU0lJU3dFVlNVOENFa1EyR2dKSkZZRWdFa1EyR2dOSkZZRUlFa1JKRjBzQ01nTVRSRVFvU3dSUVNiMUZBUlJFSXhhQlhFOEZDSUFpQUZ3QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRThGVUU4RVVFd1dWd1lDVUVzQlVFeFFUd0pRS1ZCTEFieEl2eVJETmhvQlNTTlpJZ2hMQVJVU1JDaE1VRW05UlFGRVNiNUlURWtsSXJvWFNpSzZGeUlJU3dKT0Fyb3BFa1JMQVNWWlR3SWpUd0pZZ0FvQUNGSmxiR1ZoYzJWa1VDTVdYRlJMQWJ4SXZ5UkROaG9CU1NOWklnaExBUlVTUkNoTVVFbTlSUUZFU2I1SVRFa2xJcm9YU2lLNkZ5SUlTd0pPQXJvcEVrUkxBU1ZaVHdJalR3SllnQW9BQ0ZKbFpuVnVaR1ZrVUVzQnZFaS9KRU0yR2dGSkkxa2lDRXNCRlJKRUtFeFFTYjFGQVVSSnZraE1TU1VpdWhkS0lyb1hJZ2hMQWs0Q3Vpa1NSRXNCSlZsUEFpTlBBbGlBQ3dBSlEyRnVZMlZzYkdWa1VFc0J2RWkvSkVNMkdnRkpJMWtpQ0VzQkZSSkVLRXhRU2IxRkFVUytTSUFFRlI5OGRVeFFzQ1JEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
