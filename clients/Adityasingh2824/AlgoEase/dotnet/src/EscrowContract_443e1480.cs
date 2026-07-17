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

namespace Arc56.Generated.Adityasingh2824.AlgoEase.EscrowContract_443e1480
{


    //
    // ARC-4 multi-escrow contract using BoxMap keyed by task_id.
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
                public Algorand.Address Client { get; set; }

                public Algorand.Address Freelancer { get; set; }

                public ulong Amount { get; set; }

                public ulong UsdcAssetId { get; set; }

                public ulong Status { get; set; }

                public string IpfsHash { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vClient.From(Client);
                    ret.AddRange(vClient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFreelancer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFreelancer.From(Freelancer);
                    ret.AddRange(vFreelancer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUsdcAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUsdcAssetId.From(UsdcAssetId);
                    ret.AddRange(vUsdcAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.From(IpfsHash);
                    stringRef[ret.Count] = vIpfsHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vClient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClient = vClient.ToValue();
                    if (valueClient is Algorand.Address vClientValue) { ret.Client = vClientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFreelancer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFreelancer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFreelancer = vFreelancer.ToValue();
                    if (valueFreelancer is Algorand.Address vFreelancerValue) { ret.Freelancer = vFreelancerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUsdcAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUsdcAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUsdcAssetId = vUsdcAssetId.ToValue();
                    if (valueUsdcAssetId is ulong vUsdcAssetIdValue) { ret.UsdcAssetId = vUsdcAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    var indexIpfsHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.Decode(bytes.Skip(indexIpfsHash + prefixOffset).ToArray());
                    var valueIpfsHash = vIpfsHash.ToValue();
                    if (valueIpfsHash is string vIpfsHashValue) { ret.IpfsHash = vIpfsHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeadline = vDeadline.ToValue();
                    if (valueDeadline is ulong vDeadlineValue) { ret.Deadline = vDeadlineValue; }
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
        ///One-time admin config (creator only). Sets default USDC ASA ID.
        ///</summary>
        /// <param name="usdc_asset_id"> </param>
        public async Task Configure(ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 21, 67, 249 };
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, usdc_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 21, 67, 249 };
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, usdc_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the app into an ASA (required before receiving USDC). Creator only.
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 205, 239, 59 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 205, 239, 59 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new escrow. Must be grouped with a Payment (ALGO) to the app.
        ///For USDC, a separate create_escrow_usdc method is used.
        ///</summary>
        /// <param name="task_id"> </param>
        /// <param name="freelancer"> </param>
        /// <param name="deadline"> </param>
        /// <param name="usdc_asset_id"> </param>
        /// <param name="fund"> </param>
        public async Task CreateEscrow(PaymentTransaction fund, string task_id, Algorand.Address freelancer, ulong deadline, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 2, 6, 245, 146 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi, freelancerAbi, deadlineAbi, usdc_asset_idAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(PaymentTransaction fund, string task_id, Algorand.Address freelancer, ulong deadline, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 2, 6, 245, 146 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi, freelancerAbi, deadlineAbi, usdc_asset_idAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create escrow funded with USDC-A (ASA transfer).
        ///</summary>
        /// <param name="task_id"> </param>
        /// <param name="freelancer"> </param>
        /// <param name="deadline"> </param>
        /// <param name="usdc_asset_id"> </param>
        /// <param name="fund"> </param>
        public async Task CreateEscrowUsdc(AssetTransferTransaction fund, string task_id, Algorand.Address freelancer, ulong deadline, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 32, 36, 180, 93 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi, freelancerAbi, deadlineAbi, usdc_asset_idAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrowUsdc_Transactions(AssetTransferTransaction fund, string task_id, Algorand.Address freelancer, ulong deadline, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 32, 36, 180, 93 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi, freelancerAbi, deadlineAbi, usdc_asset_idAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer accepts the task. OPEN → ACCEPTED.
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task AcceptTask(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 156, 240, 37 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptTask_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 156, 240, 37 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer submits work. ACCEPTED → SUBMITTED.
        ///</summary>
        /// <param name="task_id"> </param>
        /// <param name="ipfs_cid"> </param>
        public async Task SubmitWork(string task_id, string ipfs_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 92, 33, 19 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi, ipfs_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitWork_Transactions(string task_id, string ipfs_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 92, 33, 19 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi, ipfs_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Client rejects submitted work. SUBMITTED → REFUNDED (immediate refund).
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task RejectWork(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 94, 136, 18 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectWork_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 94, 136, 18 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Client approves work. SUBMITTED → APPROVED.
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task Approve(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 79, 122, 240 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Approve_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 79, 122, 240 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release funds to freelancer. APPROVED → RELEASED.
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task ReleasePayment(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 243, 1, 82 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleasePayment_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 243, 1, 82 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Refund to client. Allowed if deadline passed or status is OPEN/ACCEPTED/SUBMITTED.
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task Refund(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 144, 128, 37 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.CallApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refund_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 144, 128, 37 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the numeric status of an escrow.
        ///</summary>
        /// <param name="task_id"> </param>
        public async Task<ulong> GetStatus(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 223, 244, 230 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            var result = await base.SimApp(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStatus_Transactions(string task_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 223, 244, 230 };
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); task_idAbi.From(task_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjoiQVJDLTQgbXVsdGktZXNjcm93IGNvbnRyYWN0IHVzaW5nIEJveE1hcCBrZXllZCBieSB0YXNrX2lkLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJFc2Nyb3dSZWNvcmQiOlt7Im5hbWUiOiJjbGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZyZWVsYW5jZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpcGZzX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZWFkbGluZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY29uZmlndXJlIiwiZGVzYyI6Ik9uZS10aW1lIGFkbWluIGNvbmZpZyAoY3JlYXRvciBvbmx5KS4gU2V0cyBkZWZhdWx0IFVTREMgQVNBIElELiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl9hc3NldCIsImRlc2MiOiJPcHQgdGhlIGFwcCBpbnRvIGFuIEFTQSAocmVxdWlyZWQgYmVmb3JlIHJlY2VpdmluZyBVU0RDKS4gQ3JlYXRvciBvbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfZXNjcm93IiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBlc2Nyb3cuIE11c3QgYmUgZ3JvdXBlZCB3aXRoIGEgUGF5bWVudCAoQUxHTykgdG8gdGhlIGFwcC5cbkZvciBVU0RDLCBhIHNlcGFyYXRlIGNyZWF0ZV9lc2Nyb3dfdXNkYyBtZXRob2QgaXMgdXNlZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyZWVsYW5jZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9lc2Nyb3dfdXNkYyIsImRlc2MiOiJDcmVhdGUgZXNjcm93IGZ1bmRlZCB3aXRoIFVTREMtQSAoQVNBIHRyYW5zZmVyKS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyZWVsYW5jZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ1bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0X3Rhc2siLCJkZXNjIjoiRnJlZWxhbmNlciBhY2NlcHRzIHRoZSB0YXNrLiBPUEVOIOKGkiBBQ0NFUFRFRC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfd29yayIsImRlc2MiOiJGcmVlbGFuY2VyIHN1Ym1pdHMgd29yay4gQUNDRVBURUQg4oaSIFNVQk1JVFRFRC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc19jaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVqZWN0X3dvcmsiLCJkZXNjIjoiQ2xpZW50IHJlamVjdHMgc3VibWl0dGVkIHdvcmsuIFNVQk1JVFRFRCDihpIgUkVGVU5ERUQgKGltbWVkaWF0ZSByZWZ1bmQpLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjoiQ2xpZW50IGFwcHJvdmVzIHdvcmsuIFNVQk1JVFRFRCDihpIgQVBQUk9WRUQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZV9wYXltZW50IiwiZGVzYyI6IlJlbGVhc2UgZnVuZHMgdG8gZnJlZWxhbmNlci4gQVBQUk9WRUQg4oaSIFJFTEVBU0VELiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZCIsImRlc2MiOiJSZWZ1bmQgdG8gY2xpZW50LiBBbGxvd2VkIGlmIGRlYWRsaW5lIHBhc3NlZCBvciBzdGF0dXMgaXMgT1BFTi9BQ0NFUFRFRC9TVUJNSVRURUQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N0YXR1cyIsImRlc2MiOiJSZXR1cm5zIHRoZSBudW1lcmljIHN0YXR1cyBvZiBhbiBlc2Nyb3cuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzE4LDQ3MV0sImVycm9yTWVzc2FnZSI6ImFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNV0sImVycm9yTWVzc2FnZSI6ImFzc2V0IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc4LDY4NCw3NDYsODQwLDk3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXNjcm93cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM1XSwiZXJyb3JNZXNzYWdlIjoiZGVhZGxpbmUgbm90IHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTcsNTE3LDYxNl0sImVycm9yTWVzc2FnZSI6ImZyZWVsYW5jZXIgbXVzdCBkaWZmZXIgZnJvbSBjbGllbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODMsNTk5LDYxNCw2OTAsNzAyLDc1Miw3NjMsNzk3LDgwOCw4MTUsODQ1LDg1Nyw4NjQsODc0LDg4MCw5ODAsOTg3LDk5NSwxMDc0XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MCw0MDEsNTYxLDY1NCw2NjcsNzMzLDc4Miw4MjMsOTU1LDEwNjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTcsNDA4LDU2OCw2NjEsNjc3LDc0MCw3ODksODMwLDk2MiwxMDY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OSw0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3LDIxNywyNzksMjg5LDQzMCw0NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDddLCJlcnJvck1lc3NhZ2UiOiJpcGZzX2NpZCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOSw0OTJdLCJlcnJvck1lc3NhZ2UiOiJubyBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2OSwxMDk1XSwiZXJyb3JNZXNzYWdlIjoibm8gZnVuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDUsNDk5XSwiZXJyb3JNZXNzYWdlIjoibm8gcmVrZXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTRdLCJlcnJvck1lc3NhZ2UiOiJub3QgQUNDRVBURUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDldLCJlcnJvck1lc3NhZ2UiOiJub3QgQVBQUk9WRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTVdLCJlcnJvck1lc3NhZ2UiOiJub3QgT1BFTiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1NSw4MDBdLCJlcnJvck1lc3NhZ2UiOiJub3QgU1VCTUlUVEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY1LDgxMCw4NTksOTgyXSwiZXJyb3JNZXNzYWdlIjoib25seSBjbGllbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMsMjI0XSwiZXJyb3JNZXNzYWdlIjoib25seSBjcmVhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ1LDcwNF0sImVycm9yTWVzc2FnZSI6Im9ubHkgZnJlZWxhbmNlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNSw0NzhdLCJlcnJvck1lc3NhZ2UiOiJwYXkgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMyLDQ4NV0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgc2VuZGVyIG11c3QgYmUgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyMl0sImVycm9yTWVzc2FnZSI6InJlZnVuZCBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMSw0NjRdLCJlcnJvck1lc3NhZ2UiOiJ0YXNrX2lkIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TmpVM016WXpJREI0TURBd01EQXdNREF3TURBd01EQXdNeUFpZFhOa1kxOWhjM05sZEY5cFpDSWdNSGd3TURBd01EQXdNREF3TURBd01EQXhNREEyWVNBd2VEQXdNREFnTUhnd01EQXdNREF3TURBd01EQXdNREF5SURCNE1EQXdNREF3TURBd01EQXdNREF3TkNBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnYzJWc1ppNTFjMlJqWDJGemMyVjBYMmxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMWMyUmpYMkZ6YzJWMFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z1kyeGhjM01nUlhOamNtOTNRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFESXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzJOekUxTkRObU9TQXdlR1V6WTJSbFpqTmlJREI0TURJd05tWTFPVElnTUhneU1ESTBZalExWkNBd2VEQTRPV05tTURJMUlEQjROakkxWXpJeE1UTWdNSGd6TmpWbE9EZ3hNaUF3ZURSaE5HWTNZV1l3SURCNE5qSm1NekF4TlRJZ01IZ3lNRGt3T0RBeU5TQXdlRGc0WkdabU5HVTJJQzh2SUcxbGRHaHZaQ0FpWTI5dVptbG5kWEpsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZjSFJmYVc1ZllYTnpaWFFvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlY5bGMyTnliM2NvYzNSeWFXNW5MR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDJWelkzSnZkMTkxYzJSaktITjBjbWx1Wnl4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNZWGhtWlhJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdOalpYQjBYM1JoYzJzb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW0xcGRGOTNiM0pyS0hOMGNtbHVaeXh6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnFaV04wWDNkdmNtc29jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVVvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiR1ZoYzJWZmNHRjViV1Z1ZENoemRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWljbVZtZFc1a0tITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmMzUmhkSFZ6S0hOMGNtbHVaeWwxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqYjI1bWFXZDFjbVVnYjNCMFgybHVYMkZ6YzJWMElHTnlaV0YwWlY5bGMyTnliM2NnWTNKbFlYUmxYMlZ6WTNKdmQxOTFjMlJqSUdGalkyVndkRjkwWVhOcklITjFZbTFwZEY5M2IzSnJJSEpsYW1WamRGOTNiM0pySUdGd2NISnZkbVVnY21Wc1pXRnpaVjl3WVhsdFpXNTBJSEpsWm5WdVpDQm5aWFJmYzNSaGRIVnpDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTWpBNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNWpiMjVtYVdkMWNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjI1bWFXZDFjbVU2Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaWIyNXNlU0JqY21WaGRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1kzSmxZWFJ2Y2dvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MblZ6WkdOZllYTnpaWFJmYVdRZ1BTQjFjMlJqWDJGemMyVjBYMmxrTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkWE5rWTE5aGMzTmxkRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5NWpiMjUwY21GamRDNUZjMk55YjNkRGIyNTBjbUZqZEM1dmNIUmZhVzVmWVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSZmFXNWZZWE56WlhRNkNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWliMjVzZVNCamNtVmhkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZM0psWVhSdmNnb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qY3pMVGM0Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvM015MDNPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNWpjbVZoZEdWZlpYTmpjbTkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJWelkzSnZkem9LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxjblFnYTJWNUlHNXZkQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTXNJQ0owWVhOclgybGtJR0ZzY21WaFpIa2daWGhwYzNSeklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnZEdGemExOXBaQ0JoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QmhiVzkxYm5SZmJtRjBhWFpsSUQwZ1puVnVaQzVoYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZEY5dVlYUnBkbVVnUGlBd0xDQWlZVzF2ZFc1MElHMTFjM1FnWW1VZ1BpQXdJZ29nSUNBZ1lYTnpaWEowSUM4dklHRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QmhjM05sY25RZ1puVnVaQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaWNHRjVJSFJ2SUdGd2NDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhCaGVTQjBieUJoY0hBS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdaMWJtUXVjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKd1lYbHRaVzUwSUhObGJtUmxjaUJ0ZFhOMElHSmxJR05oYkd4bGNpSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxMWMzUWdZbVVnWTJGc2JHVnlDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdablZ1WkM1amJHOXpaVjl5WlcxaGFXNWtaWEpmZEc4Z1BUMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeXdnSW01dklHTnNiM05sSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1kyeHZjMlVLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0JtZFc1a0xuSmxhMlY1WDNSdklEMDlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zSUNKdWJ5QnlaV3RsZVNJS0lDQWdJR2QwZUc1eklGSmxhMlY1Vkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdWJ5QnlaV3RsZVFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCeVpYUjFjbTRnWm5KbFpXeGhibU5sY2lBOVBTQmhjbU0wTGtGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNRE10TVRBMENpQWdJQ0F2THlBaklGcGxjbThnWVdSa2NtVnpjeUE5SUc5d1pXNGdZbTkxYm5SNU95Qm1jbVZsYkdGdVkyVnlJR05zWVdsdGN5QnZiaUJoWTJObGNIUmZkR0Z6YXk0S0lDQWdJQzh2SUdsbUlHNXZkQ0J6Wld4bUxtbHpYMjl3Wlc1ZlpuSmxaV3hoYm1ObGNpaG1jbVZsYkdGdVkyVnlLVG9LSUNBZ0lHSnVlaUJqY21WaGRHVmZaWE5qY205M1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdaeVpXVnNZVzVqWlhJdWJtRjBhWFpsSUNFOUlGUjRiaTV6Wlc1a1pYSXNJQ0ptY21WbGJHRnVZMlZ5SUcxMWMzUWdaR2xtWm1WeUlHWnliMjBnWTJ4cFpXNTBJZ29nSUNBZ1pHbG5JRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWm5KbFpXeGhibU5sY2lCdGRYTjBJR1JwWm1abGNpQm1jbTl0SUdOc2FXVnVkQW9LWTNKbFlYUmxYMlZ6WTNKdmQxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QmpiR2xsYm5ROVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0dGdGIzVnVkRjl1WVhScGRtVXBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXdOeTB4TVRZS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdHJaWGxkSUQwZ1JYTmpjbTkzVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdOc2FXVnVkRDFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWm5KbFpXeGhibU5sY2oxbWNtVmxiR0Z1WTJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2hoYlc5MWJuUmZibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0IxYzJSalgyRnpjMlYwWDJsa1BYVnpaR05mWVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5UFVFVk9LU3dLSUNBZ0lDOHZJQ0FnSUNCcGNHWnpYMmhoYzJnOVlYSmpOQzVUZEhKcGJtY29JaUlwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFlXUnNhVzVsUFdSbFlXUnNhVzVsTEFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREV3TURaaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z2FYQm1jMTlvWVhOb1BXRnlZelF1VTNSeWFXNW5LQ0lpS1N3S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEEzTFRFeE5nb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZHpXMnRsZVYwZ1BTQkZjMk55YjNkU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1kyeHBaVzUwUFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxiR0Z1WTJWeVBXWnlaV1ZzWVc1alpYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0dGdGIzVnVkRjl1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhWelpHTmZZWE56WlhSZmFXUTlkWE5rWTE5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME5qUW9VMVJCVkZWVFgwOVFSVTRwTEFvZ0lDQWdMeThnSUNBZ0lHbHdabk5mYUdGemFEMWhjbU0wTGxOMGNtbHVaeWdpSWlrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmhaR3hwYm1VOVpHVmhaR3hwYm1Vc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdVkyOXVkSEpoWTNRdVJYTmpjbTkzUTI5dWRISmhZM1F1WTNKbFlYUmxYMlZ6WTNKdmQxOTFjMlJqVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJWelkzSnZkMTkxYzJSak9nb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdZWE56WlhKMElHdGxlU0J1YjNRZ2FXNGdjMlZzWmk1bGMyTnliM2R6TENBaWRHRnphMTlwWkNCaGJISmxZV1I1SUdWNGFYTjBjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTlRjek5qTUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIUmhjMnRmYVdRZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUdGdGIzVnVkRjl1WVhScGRtVWdQU0JtZFc1a0xtRnpjMlYwWDJGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwWDI1aGRHbDJaU0ErSURBc0lDSmhiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQWlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0NpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QmhjM05sY25RZ1puVnVaQzVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpY0dGNUlIUnZJR0Z3Y0NJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjVJSFJ2SUdGd2NBb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXpOQW9nSUNBZ0x5OGdZWE56WlhKMElHWjFibVF1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSndZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJR0psSUdOaGJHeGxjaUlLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnWW1VZ1kyRnNiR1Z5Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNWhjM05sZEY5amJHOXpaVjkwYnlBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0FpYm04Z1kyeHZjMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJR05zYjNObENpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UTTJDaUFnSUNBdkx5QmhjM05sY25RZ1puVnVaQzV5Wld0bGVWOTBieUE5UFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxDQWlibThnY21WclpYa2lDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsYTJWNVZHOEtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJ5Wld0bGVRb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdZWE56WlhKMElHWjFibVF1ZUdabGNsOWhjM05sZEM1cFpDQTlQU0IxYzJSalgyRnpjMlYwWDJsa0xtNWhkR2wyWlN3Z0ltRnpjMlYwSUcxcGMyMWhkR05vSWdvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHMXBjMjFoZEdOb0NpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCbWNtVmxiR0Z1WTJWeUlEMDlJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektRb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnYVdZZ2JtOTBJSE5sYkdZdWFYTmZiM0JsYmw5bWNtVmxiR0Z1WTJWeUtHWnlaV1ZzWVc1alpYSXBPZ29nSUNBZ1ltNTZJR055WldGMFpWOWxjMk55YjNkZmRYTmtZMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1jbVZsYkdGdVkyVnlMbTVoZEdsMlpTQWhQU0JVZUc0dWMyVnVaR1Z5TENBaVpuSmxaV3hoYm1ObGNpQnRkWE4wSUdScFptWmxjaUJtY205dElHTnNhV1Z1ZENJS0lDQWdJR1JwWnlBMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHWnlaV1ZzWVc1alpYSWdiWFZ6ZENCa2FXWm1aWElnWm5KdmJTQmpiR2xsYm5RS0NtTnlaV0YwWlY5bGMyTnliM2RmZFhOa1kxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QmpiR2xsYm5ROVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUwTlFvZ0lDQWdMeThnWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0dGdGIzVnVkRjl1WVhScGRtVXBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBNaTB4TlRFS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdHJaWGxkSUQwZ1JYTmpjbTkzVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdOc2FXVnVkRDFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWm5KbFpXeGhibU5sY2oxbWNtVmxiR0Z1WTJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2hoYlc5MWJuUmZibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0IxYzJSalgyRnpjMlYwWDJsa1BYVnpaR05mWVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5UFVFVk9LU3dLSUNBZ0lDOHZJQ0FnSUNCcGNHWnpYMmhoYzJnOVlYSmpOQzVUZEhKcGJtY29JaUlwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFlXUnNhVzVsUFdSbFlXUnNhVzVsTEFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREV3TURaaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFME9Bb2dJQ0FnTHk4Z2FYQm1jMTlvWVhOb1BXRnlZelF1VTNSeWFXNW5LQ0lpS1N3S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFF5TFRFMU1Rb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZHpXMnRsZVYwZ1BTQkZjMk55YjNkU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1kyeHBaVzUwUFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxiR0Z1WTJWeVBXWnlaV1ZzWVc1alpYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0dGdGIzVnVkRjl1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhWelpHTmZZWE56WlhSZmFXUTlkWE5rWTE5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME5qUW9VMVJCVkZWVFgwOVFSVTRwTEFvZ0lDQWdMeThnSUNBZ0lHbHdabk5mYUdGemFEMWhjbU0wTGxOMGNtbHVaeWdpSWlrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmhaR3hwYm1VOVpHVmhaR3hwYm1Vc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFeE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0xtTnZiblJ5WVdOMExrVnpZM0p2ZDBOdmJuUnlZV04wTG1GalkyVndkRjkwWVhOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV05qWlhCMFgzUmhjMnM2Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WelkzSnZkM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UVTNMVEUxT0FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWxjMk55YjNkelcydGxlVjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RMk5DaFRWRUZVVlZOZlQxQkZUaWtzSUNKdWIzUWdUMUJGVGlJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNoVFZFRlVWVk5mVDFCRlRpa3NJQ0p1YjNRZ1QxQkZUaUlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQlBVRVZPQ2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCcFppQnpaV3htTG1selgyOXdaVzVmWm5KbFpXeGhibU5sY2loeVpXTnZjbVF1Wm5KbFpXeGhibU5sY2lrNkNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdaeVpXVnNZVzVqWlhJZ1BUMGdZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcENpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJwWmlCelpXeG1MbWx6WDI5d1pXNWZabkpsWld4aGJtTmxjaWh5WldOdmNtUXVabkpsWld4aGJtTmxjaWs2Q2lBZ0lDQmllaUJoWTJObGNIUmZkR0Z6YTE5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdJVDBnY21WamIzSmtMbU5zYVdWdWRDNXVZWFJwZG1Vc0lDSm1jbVZsYkdGdVkyVnlJRzExYzNRZ1pHbG1abVZ5SUdaeWIyMGdZMnhwWlc1MElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm1jbVZsYkdGdVkyVnlJRzExYzNRZ1pHbG1abVZ5SUdaeWIyMGdZMnhwWlc1MENpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QnlaV052Y21RdVpuSmxaV3hoYm1ObGNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnWkdsbklERUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSEpsY0d4aFkyVXlJRE15Q2lBZ0lDQmlkWEo1SURJS0NtRmpZMlZ3ZEY5MFlYTnJYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZRVU5EUlZCVVJVUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ESUtJQ0FnSUhKbGNHeGhZMlV5SURnd0NpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UWTNDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkM05iYTJWNVhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUxTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BoWTJObGNIUmZkR0Z6YTE5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVtY21WbGJHRnVZMlZ5TG01aGRHbDJaU3dnSW05dWJIa2dabkpsWld4aGJtTmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dabkpsWld4aGJtTmxjZ29nSUNBZ1lpQmhZMk5sY0hSZmRHRnphMTloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVjM1ZpYldsMFgzZHZjbXRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRXSnRhWFJmZDI5eWF6b0tJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE56TUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56TTJNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWE5qY205M2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TnpNdE1UYzBDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRFkwS0ZOVVFWUlZVMTlCUTBORlVGUkZSQ2tzSUNKdWIzUWdRVU5EUlZCVVJVUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBNE1Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVGMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZRVU5EUlZCVVJVUXBMQ0FpYm05MElFRkRRMFZRVkVWRUlnb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURJS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCQlEwTkZVRlJGUkFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFM05Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjbVZqYjNKa0xtWnlaV1ZzWVc1alpYSXVibUYwYVhabExDQWliMjVzZVNCbWNtVmxiR0Z1WTJWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCbWNtVmxiR0Z1WTJWeUNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QmhjM05sY25RZ2FYQm1jMTlqYVdRdVlubDBaWE11YkdWdVozUm9JRDRnTUN3Z0ltbHdabk5mWTJsa0lISmxjWFZwY21Wa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhWEJtYzE5amFXUWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZVMVZDVFVsVVZFVkVLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUhKbGNHeGhZMlV5SURnd0NpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QnlaV052Y21RdWFYQm1jMTlvWVhOb0lEMGdhWEJtYzE5amFXUUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNjMXRyWlhsZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtWelkzSnZkME52Ym5SeVlXTjBMbkpsYW1WamRGOTNiM0pyVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnFaV04wWDNkdmNtczZDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1UTUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56TTJNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WelkzSnZkM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qRXpMVEl4TkFvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWxjMk55YjNkelcydGxlVjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RMk5DaFRWRUZVVlZOZlUxVkNUVWxVVkVWRUtTd2dJbTV2ZENCVFZVSk5TVlJVUlVRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RMk5DaFRWRUZVVlZOZlUxVkNUVWxVVkVWRUtTd2dJbTV2ZENCVFZVSk5TVlJVUlVRaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TXdvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUZOVlFrMUpWRlJGUkFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjbVZqYjNKa0xtTnNhV1Z1ZEM1dVlYUnBkbVVzSUNKdmJteDVJR05zYVdWdWRDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCamJHbGxiblFLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TVRZS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdHJaWGxkSUQwZ2MyVnNaaTVmY21WbWRXNWtYMk5zYVdWdWRDaHlaV052Y21RcExtTnZjSGtvS1FvZ0lDQWdZMkZzYkhOMVlpQmZjbVZtZFc1a1gyTnNhV1Z1ZEFvZ0lDQWdjRzl3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVZWEJ3Y205MlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0hKdmRtVTZDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1qSUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56TTJNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpJeUxUSXlNd29nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1bGMyTnliM2R6VzJ0bGVWMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNoVFZFRlVWVk5mVTFWQ1RVbFVWRVZFS1N3Z0ltNXZkQ0JUVlVKTlNWUlVSVVFpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl5TXdvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBOalFvVTFSQlZGVlRYMU5WUWsxSlZGUkZSQ2tzSUNKdWIzUWdVMVZDVFVsVVZFVkVJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQlRWVUpOU1ZSVVJVUUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZMnhwWlc1MENpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qSTJMVEl5TndvZ0lDQWdMeThnY21WamIzSmtMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0ZOVVFWUlZVMTlCVUZCU1QxWkZSQ2tLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeU5nb2dJQ0FnTHk4Z2NtVmpiM0prTG5OMFlYUjFjeUE5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlVGQlNUMVpGUkNrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREEwQ2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMkxUSXlOd29nSUNBZ0x5OGdjbVZqYjNKa0xuTjBZWFIxY3lBOUlHRnlZelF1VlVsdWREWTBLRk5VUVZSVlUxOUJVRkJTVDFaRlJDa0tJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNjMXRyWlhsZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNXlaV3hsWVhObFgzQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV3hsWVhObFgzQmhlVzFsYm5RNkNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qSTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVaWE5qY205M2MxdHJaWGxkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkxTnpNMk13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpZM0p2ZDNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNak16TFRJek5Bb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVsYzJOeWIzZHpXMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZRVkJRVWs5V1JVUXBMQ0FpYm05MElFRlFVRkpQVmtWRUlnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU16UUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlVGQlNUMVpGUkNrc0lDSnViM1FnUVZCUVVrOVdSVVFpQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdOQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJRUZRVUZKUFZrVkVDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNak0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCeVpXTnZjbVF1WTJ4cFpXNTBMbTVoZEdsMlpTd2dJbTl1YkhrZ1kyeHBaVzUwSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR05zYVdWdWRBb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdjR0Y1YjNWMElEMGdjbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TXpnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdmRYUWdQaUF3TENBaWJtOGdablZ1WkhNaUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1puVnVaSE1LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRBS0lDQWdJQzh2SUdaeVpXVnNZVzVqWlhJZ1BTQnlaV052Y21RdVpuSmxaV3hoYm1ObGNpNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTBNUW9nSUNBZ0x5OGdZWE56WlhSZmFXUWdQU0J5WldOdmNtUXVkWE5rWTE5aGMzTmxkRjlwWkM1dVlYUnBkbVVLSUNBZ0lIQjFjMmhwYm5RZ056SUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpRekNpQWdJQ0F2THlCcFppQmhjM05sZEY5cFpDQStJREE2Q2lBZ0lDQmllaUJ5Wld4bFlYTmxYM0JoZVcxbGJuUmZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRRdE1qUTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2hoYzNObGRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5Wm5KbFpXeGhibU5sY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5Y0dGNWIzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTBOQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpRNENpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakkwTkMweU5Ea0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLR0Z6YzJWMFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFtY21WbGJHRnVZMlZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tjbVZzWldGelpWOXdZWGx0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5UY0tJQ0FnSUM4dklISmxZMjl5WkM1aGJXOTFiblFnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTFPQW9nSUNBZ0x5OGdjbVZqYjNKa0xuTjBZWFIxY3lBOUlHRnlZelF1VlVsdWREWTBLRk5VUVZSVlUxOVNSVXhGUVZORlJDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURVS0lDQWdJSEpsY0d4aFkyVXlJRGd3Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVNUNpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQzTmJhMlY1WFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXlPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHlaV3hsWVhObFgzQmhlVzFsYm5SZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalV4TFRJMU5Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFdaeVpXVnNZVzVqWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJMU1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTFOQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5URXRNalUxQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlabkpsWld4aGJtTmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y0dGNWIzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ2NtVnNaV0Z6WlY5d1lYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29LQ2k4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1RmMyTnliM2REYjI1MGNtRmpkQzV5WldaMWJtUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldaMWJtUTZDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5qVUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56TTJNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6WTNKdmQzTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnlaV052Y21RdVkyeHBaVzUwTG01aGRHbDJaU3dnSW05dWJIa2dZMnhwWlc1MElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJMk5TMHlOallLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjbVZqYjNKa0xtTnNhV1Z1ZEM1dVlYUnBkbVVzSUNKdmJteDVJR05zYVdWdWRDSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWTJ4cFpXNTBDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalk0Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0J5WldOdmNtUXVjM1JoZEhWekxtNWhkR2wyWlFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qWTVDaUFnSUNBdkx5QmtaV0ZrYkdsdVpTQTlJSEpsWTI5eVpDNWtaV0ZrYkdsdVpTNXVZWFJwZG1VS0lDQWdJSEIxYzJocGJuUWdPVGdLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJM01Bb2dJQ0FnTHk4Z2JtOTNJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lOelFLSUNBZ0lDOHZJSE4wWVhSMWN5QTlQU0JUVkVGVVZWTmZUMUJGVGlCdmNpQnpkR0YwZFhNZ1BUMGdVMVJCVkZWVFgwRkRRMFZRVkVWRUlHOXlJSE4wWVhSMWN5QTlQU0JUVkVGVVZWTmZVMVZDVFVsVVZFVkVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXWjFibVJmWW05dmJGOTBjblZsUURRS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldaMWJtUmZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVpXWjFibVJmWW05dmJGOW1ZV3h6WlVBMUNncHlaV1oxYm1SZlltOXZiRjkwY25WbFFEUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tjbVZtZFc1a1gySnZiMnhmYldWeVoyVkFOam9LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TnpZS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5eVpXWjFibVJoWW14bFgzTjBZWFIxY3l3Z0luSmxablZ1WkNCdWIzUWdZV3hzYjNkbFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpXWjFibVFnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU56Y3RNamM0Q2lBZ0lDQXZMeUFqSUVGbWRHVnlJRk5WUWsxSlZGUkZSQ3dnY21WeGRXbHlaU0JrWldGa2JHbHVaU0IwYnlCb1lYWmxJSEJoYzNObFpBb2dJQ0FnTHk4Z2FXWWdjM1JoZEhWeklEMDlJRk5VUVZSVlUxOVRWVUpOU1ZSVVJVUTZDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WbWRXNWtYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTNPUW9nSUNBZ0x5OGdZWE56WlhKMElHNXZkeUErUFNCa1pXRmtiR2x1WlN3Z0ltUmxZV1JzYVc1bElHNXZkQ0J5WldGamFHVmtJZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCa1pXRmtiR2x1WlNCdWIzUWdjbVZoWTJobFpBb0tjbVZtZFc1a1gyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU9ERUtJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNjMXRyWlhsZElEMGdjMlZzWmk1ZmNtVm1kVzVrWDJOc2FXVnVkQ2h5WldOdmNtUXBMbU52Y0hrb0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnWDNKbFpuVnVaRjlqYkdsbGJuUUtJQ0FnSUhCdmNBb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpZeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbFpuVnVaRjlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ5WldaMWJtUmZZbTl2YkY5dFpYSm5aVUEyQ2dvS0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0xtTnZiblJ5WVdOMExrVnpZM0p2ZDBOdmJuUnlZV04wTG1kbGRGOXpkR0YwZFhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYzNSaGRIVnpPZ29nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakk0TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpnM0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbVZ6WTNKdmQzTmJhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTlRjek5qTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakk0TnkweU9EZ0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTI5eVpDNXpkR0YwZFhNS0lDQWdJSEIxYzJocGJuUWdPREFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJNE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVYM0psWm5WdVpGOWpiR2xsYm5Rb2NtVmpiM0prT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpPZ3BmY21WbWRXNWtYMk5zYVdWdWREb0tJQ0FnSUM4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hPREl0TVRnekNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjl5WldaMWJtUmZZMnhwWlc1MEtITmxiR1lzSUhKbFkyOXlaRG9nUlhOamNtOTNVbVZqYjNKa0tTQXRQaUJGYzJOeWIzZFNaV052Y21RNkNpQWdJQ0J3Y205MGJ5QXhJRElLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUhCaGVXOTFkQ0E5SUhKbFkyOXlaQzVoYlc5MWJuUXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RZS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdmRYUWdQaUF3TENBaWJtOGdablZ1WkhNaUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1puVnVaSE1LSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RnS0lDQWdJQzh2SUdOc2FXVnVkQ0E5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFNE9Rb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQnlaV052Y21RdWRYTmtZMTloYzNObGRGOXBaQzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdhV1lnWVhOelpYUmZhV1FnUGlBd09nb2dJQ0FnWW5vZ1gzSmxablZ1WkY5amJHbGxiblJmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE9USXRNVGszQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoaGMzTmxkRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVkyeHBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE9USXRNVGszQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoaGMzTmxkRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVkyeHBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tYM0psWm5WdVpGOWpiR2xsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd05Rb2dJQ0FnTHk4Z2NtVmpiM0prTG1GdGIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRIVnpJRDBnWVhKak5DNVZTVzUwTmpRb1UxUkJWRlZUWDFKRlJsVk9SRVZFS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdOZ29nSUNBZ2NtVndiR0ZqWlRJZ09EQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNUW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl3TndvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTI5eVpBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LWDNKbFpuVnVaRjlqYkdsbGJuUmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNUxUSXdNd29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXTnNhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNHRjViM1YwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmhiR2R2WldGelpWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVGs1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakU1T1MweU1ETUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxamJHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaUlGOXlaV1oxYm1SZlkyeHBaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBaVlJQTJWell3Z0FBQUFBQUFBQUF3MTFjMlJqWDJGemMyVjBYMmxrQ2dBQUFBQUFBQUFCQUdvQ0FBQUlBQUFBQUFBQUFBSUlBQUFBQUFBQUFBUUlBQUFBQUFBQUFBQXhHRUFBQXlvaVp6RWJRUUJjTVJrVVJERVlSSUlMQkdjVlEva0U0ODN2T3dRQ0J2V1NCQ0FrdEYwRUNKendKUVJpWENFVEJEWmVpQklFU2s5NjhBUmk4d0ZTQkNDUWdDVUVpTi8wNWpZYUFJNExBQWtBSFFCQUFOY0Jkd0hVQWlNQ1ZBSjlBd0VEYWdBeEdSUXhHQlFRUXpZYUFVa1ZKQkpFTVFBeUNSSkVGeXBNWnlORE5ob0JTUlVrRWtRWE1RQXlDUkpFc1RJS0lySVNzaFN5RVlFRXNoQWlzZ0d6STBNMkdnRkpJbGtsQ0VzQkZSSkVOaG9DU1U0Q1NSV0JJQkpFTmhvRFNVNERGU1FTUkRZYUJFbE9BeFVrRWtReEZpTUpTVGdRSXhKRUtFOERVRWxPQTcxRkFSUkVTVGdJU1U0RFJFazRCeklLRWtSSk9BQXhBQkpFU1RnSk1nTVNSRGdnTWdNU1JESURFa0FBQmtzRU1RQVRSREVBU3dFV01nY1dUd0pMQjFCUEFsQkxCRkFyVUV4UVN3UlFKd1JRU3dKSnZFaE12eU5ETmhvQlNTSlpKUWhMQVJVU1JEWWFBa2xPQWtrVmdTQVNSRFlhQTBsT0F4VWtFa1EyR2dSSlRnTkpGU1FTUkRFV0l3bEpPQkNCQkJKRUtFOEVVRWxPQkwxRkFSUkVTVGdTU1U0RVJFazRGRElLRWtSSk9BQXhBQkpFU1RnVk1nTVNSRWs0SURJREVrUTRFVXdYRWtReUF4SkFBQVpMQkRFQUUwUXhBRXNCRmpJSEZrOENTd2RRVHdKUVN3UlFLMUJNVUVzRVVDY0VVRXNDU2J4SVRMOGpRellhQVVraVdTVUlTd0VWRWtRb1RGQkhBcjVNVGdKRVNZRlFKTHFBQ0FBQUFBQUFBQUFCcUVTQklFbTZTVElERWtFQUlURUFTd01pZ1NDNkUwUkxBVEVBWENCRkFrc0JKd1ZjVUVzRFNieElUTDhqUXpFQVN3RVNSRUwvNkRZYUFVa2lXU1VJU3dFVkVrUTJHZ0pKSWxrbENFc0JGVWxQQWhKRUtFOERVRW0rUkVzQmdWQWt1aWNGcUVReEFFc0NnU0JKdWhKRVR3SkVLVnhRU1lGWVdTSk1XRThDVUVzQnZFaS9JME0yR2dGSklsa2xDRXNCRlJKRUtFeFFTYjVFU3dHQlVDUzZLYWhFTVFCTEFpS0JJTG9TUklnQlBVaExBYnhJdnlORE5ob0JTU0paSlFoTEFSVVNSQ2hNVUVtQlVDUzZLYWhFTVFCTEFTS0JJTG9TUklGUUp3YTdJME0yR2dGSklsa2xDRXNCRlJKRUtFeFFSd0srVEU0Q1JFbUJVQ1M2Sndhb1JERUFTd0VpZ1NDNkVrUkpnVUFrdWhkSlRnSkVTWUVnU2JwT0FvRklKTG9YU1U0Q1FRQXRzYklTU3dHeUZFbXlFWUVFc2hBaXNnR3pTd0luQjF4QWdBZ0FBQUFBQUFBQUJWeFFTd1JKdkVoTXZ5TkRzYklJU3dHeUJ5T3lFQ0t5QWJOQy85UTJHZ0ZKSWxrbENFc0JGUkpFS0V4UVJ3SytURTRDUkRFQVN3RWlnU0M2RWtSSmdWQWt1aGRKVHdLQllpUzZGMHd5QjB3akVrQUFEMHNDSlJKQUFBaExBb0VERWtFQUhpTkVTd0tCQXhKQkFBVkpTd0lQUkVzRGlBQXRTRXNGU2J4SVRMOGpReUpDLzk4MkdnRkpJbGtsQ0VzQkZSSkVLRXhRZ1ZBa3VvQUVGUjk4ZFV4UXNDTkRpZ0VDaS8rQlFGdEpSSXYvVndBZ1RJdi9nVWhiU1U0Q1FRQXhzYklTaXdDeUZJc0JzaEdCQkxJUUlySUJzNHYvSndkY1FFbU0vNEFJQUFBQUFBQUFBQVpjVUVjQ2pQOVBBMDhEaWJHeUNJc0FzZ2Nqc2hBaXNnR3pRdi9SIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
