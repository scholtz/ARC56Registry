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

namespace Arc56.Generated.Adityasingh2824.AlgoEase.EscrowContract_14f3d373
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjoiQVJDLTQgbXVsdGktZXNjcm93IGNvbnRyYWN0IHVzaW5nIEJveE1hcCBrZXllZCBieSB0YXNrX2lkLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJFc2Nyb3dSZWNvcmQiOlt7Im5hbWUiOiJjbGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZyZWVsYW5jZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpcGZzX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZWFkbGluZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY29uZmlndXJlIiwiZGVzYyI6Ik9uZS10aW1lIGFkbWluIGNvbmZpZyAoY3JlYXRvciBvbmx5KS4gU2V0cyBkZWZhdWx0IFVTREMgQVNBIElELiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl9hc3NldCIsImRlc2MiOiJPcHQgdGhlIGFwcCBpbnRvIGFuIEFTQSAocmVxdWlyZWQgYmVmb3JlIHJlY2VpdmluZyBVU0RDKS4gQ3JlYXRvciBvbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfZXNjcm93IiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBlc2Nyb3cuIE11c3QgYmUgZ3JvdXBlZCB3aXRoIGEgUGF5bWVudCAoQUxHTykgdG8gdGhlIGFwcC5cbkZvciBVU0RDLCBhIHNlcGFyYXRlIGNyZWF0ZV9lc2Nyb3dfdXNkYyBtZXRob2QgaXMgdXNlZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyZWVsYW5jZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9lc2Nyb3dfdXNkYyIsImRlc2MiOiJDcmVhdGUgZXNjcm93IGZ1bmRlZCB3aXRoIFVTREMtQSAoQVNBIHRyYW5zZmVyKS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyZWVsYW5jZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ1bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0X3Rhc2siLCJkZXNjIjoiRnJlZWxhbmNlciBhY2NlcHRzIHRoZSB0YXNrLiBPUEVOIOKGkiBBQ0NFUFRFRC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfd29yayIsImRlc2MiOiJGcmVlbGFuY2VyIHN1Ym1pdHMgd29yay4gQUNDRVBURUQg4oaSIFNVQk1JVFRFRC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc19jaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVqZWN0X3dvcmsiLCJkZXNjIjoiQ2xpZW50IHJlamVjdHMgc3VibWl0dGVkIHdvcmsuIFNVQk1JVFRFRCDihpIgUkVGVU5ERUQgKGltbWVkaWF0ZSByZWZ1bmQpLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjoiQ2xpZW50IGFwcHJvdmVzIHdvcmsuIFNVQk1JVFRFRCDihpIgQVBQUk9WRUQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZV9wYXltZW50IiwiZGVzYyI6IlJlbGVhc2UgZnVuZHMgdG8gZnJlZWxhbmNlci4gQVBQUk9WRUQg4oaSIFJFTEVBU0VELiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZCIsImRlc2MiOiJSZWZ1bmQgdG8gY2xpZW50LiBBbGxvd2VkIGlmIGRlYWRsaW5lIHBhc3NlZCBvciBzdGF0dXMgaXMgT1BFTi9BQ0NFUFRFRC9TVUJNSVRURUQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N0YXR1cyIsImRlc2MiOiJSZXR1cm5zIHRoZSBudW1lcmljIHN0YXR1cyBvZiBhbiBlc2Nyb3cuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTAxOCwxMDIyXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDksNDYyXSwiZXJyb3JNZXNzYWdlIjoiYW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjksNjc1LDczOCw4OTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd3MgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU4XSwiZXJyb3JNZXNzYWdlIjoiZGVhZGxpbmUgbm90IHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDgsNTA4LDYwN10sImVycm9yTWVzc2FnZSI6ImZyZWVsYW5jZXIgbXVzdCBkaWZmZXIgZnJvbSBjbGllbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzQsNTkwLDYwNSw2ODEsNjkzLDc0NCw3NTUsNzg1LDc5Niw4MDMsODI2LDgzOCw4NDUsODU0LDg2NCw5MDMsOTEwLDkxOCw5OTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNV0sImVycm9yTWVzc2FnZSI6Imluc3VmZmljaWVudCBlc2Nyb3cgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxLDM5Miw1NTIsNjQ1LDY1OCw3MjQsNzcwLDgxMSw4NzksOTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4LDM5OSw1NTksNjUyLDY2OCw3MzEsNzc3LDgxOCw4ODYsOTg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCw0MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4LDIwOCwyNzAsMjgwLDQyMSw0MzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OThdLCJlcnJvck1lc3NhZ2UiOiJpcGZzX2NpZCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMCw0ODNdLCJlcnJvck1lc3NhZ2UiOiJubyBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0OCwxMDEyLDEwODNdLCJlcnJvck1lc3NhZ2UiOiJubyBmdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNiw0OTBdLCJlcnJvck1lc3NhZ2UiOiJubyByZWtleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NV0sImVycm9yTWVzc2FnZSI6Im5vdCBBQ0NFUFRFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzMF0sImVycm9yTWVzc2FnZSI6Im5vdCBBUFBST1ZFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4Nl0sImVycm9yTWVzc2FnZSI6Im5vdCBPUEVOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ3LDc4OF0sImVycm9yTWVzc2FnZSI6Im5vdCBTVUJNSVRURUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTcsNzk4LDg0MCw5MDVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGNsaWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NCwyMTVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzYsNjk1XSwiZXJyb3JNZXNzYWdlIjoib25seSBmcmVlbGFuY2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2LDQ2OV0sImVycm9yTWVzc2FnZSI6InBheSB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjMsNDc2XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBzZW5kZXIgbXVzdCBiZSBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDVdLCJlcnJvck1lc3NhZ2UiOiJyZWZ1bmQgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDIsNDU1XSwiZXJyb3JNZXNzYWdlIjoidGFza19pZCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0M10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5qVTNNell6SURCNE1EQXdNREF3TURBd01EQXdNREF3TXlBaWRYTmtZMTloYzNObGRGOXBaQ0lnTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBMllTQXdlREF3TURBZ01IZ3dNREF3TURBd01EQXdNREF3TURBeUlEQjRNREF3TURBd01EQXdNREF3TURBd05Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1ZFhOa1kxOWhjM05sZEY5cFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkWE5rWTE5aGMzTmxkRjlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnWTJ4aGMzTWdSWE5qY205M1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURJd0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMk56RTFORE5tT1NBd2VHVXpZMlJsWmpOaUlEQjRNREl3Tm1ZMU9USWdNSGd5TURJMFlqUTFaQ0F3ZURBNE9XTm1NREkxSURCNE5qSTFZekl4TVRNZ01IZ3pOalZsT0RneE1pQXdlRFJoTkdZM1lXWXdJREI0TmpKbU16QXhOVElnTUhneU1Ea3dPREF5TlNBd2VEZzRaR1ptTkdVMklDOHZJRzFsZEdodlpDQWlZMjl1Wm1sbmRYSmxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNIUmZhVzVmWVhOelpYUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OeVpXRjBaVjlsYzJOeWIzY29jM1J5YVc1bkxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTNKbFlYUmxYMlZ6WTNKdmQxOTFjMlJqS0hOMGNtbHVaeXhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc1lYaG1aWElwZG05cFpDSXNJRzFsZEdodlpDQWlZV05qWlhCMFgzUmhjMnNvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjFZbTFwZEY5M2IzSnJLSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WcVpXTjBYM2R2Y21zb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ3Y0hKdmRtVW9jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGJHVmhjMlZmY0dGNWJXVnVkQ2h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVm1kVzVrS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmYzNSaGRIVnpLSE4wY21sdVp5bDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpiMjVtYVdkMWNtVWdiM0IwWDJsdVgyRnpjMlYwSUdOeVpXRjBaVjlsYzJOeWIzY2dZM0psWVhSbFgyVnpZM0p2ZDE5MWMyUmpJR0ZqWTJWd2RGOTBZWE5ySUhOMVltMXBkRjkzYjNKcklISmxhbVZqZEY5M2IzSnJJR0Z3Y0hKdmRtVWdjbVZzWldGelpWOXdZWGx0Wlc1MElISmxablZ1WkNCblpYUmZjM1JoZEhWekNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakE2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5NWpiMjUwY21GamRDNUZjMk55YjNkRGIyNTBjbUZqZEM1amIyNW1hV2QxY21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjVtYVdkMWNtVTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltOXViSGtnWTNKbFlYUnZjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHTnlaV0YwYjNJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QnpaV3htTG5WelpHTmZZWE56WlhSZmFXUWdQU0IxYzJSalgyRnpjMlYwWDJsa0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZFhOa1kxOWhjM05sZEY5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtWelkzSnZkME52Ym5SeVlXTjBMbTl3ZEY5cGJsOWhjM05sZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtOXdkRjlwYmw5aGMzTmxkRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWliMjVzZVNCamNtVmhkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZM0psWVhSdmNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOek10TnpnS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvM05Rb2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOemNLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzNNeTAzT0FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZV3huYjJWaGMyVmZaWE5qY205M0xtTnZiblJ5WVdOMExrVnpZM0p2ZDBOdmJuUnlZV04wTG1OeVpXRjBaVjlsYzJOeWIzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZaWE5qY205M09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxjblFnYTJWNUlHNXZkQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTXNJQ0owWVhOclgybGtJR0ZzY21WaFpIa2daWGhwYzNSeklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnZEdGemExOXBaQ0JoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJR0Z0YjNWdWRGOXVZWFJwZG1VZ1BTQm1kVzVrTG1GdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUmZibUYwYVhabElENGdNQ3dnSW1GdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpY0dGNUlIUnZJR0Z3Y0NJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVNCMGJ5QmhjSEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjaXdnSW5CaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ1ltVWdZMkZzYkdWeUlnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViV1Z1ZENCelpXNWtaWElnYlhWemRDQmlaU0JqWVd4c1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBJR1oxYm1RdVkyeHZjMlZmY21WdFlXbHVaR1Z5WDNSdklEMDlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zSUNKdWJ5QmpiRzl6WlNJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1EyeHZjMlZTWlcxaGFXNWtaWEpVYndvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dklHTnNiM05sQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCbWRXNWtMbkpsYTJWNVgzUnZJRDA5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSnVieUJ5Wld0bGVTSUtJQ0FnSUdkMGVHNXpJRkpsYTJWNVZHOEtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJ5Wld0bGVRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJSEpsZEhWeWJpQm1jbVZsYkdGdVkyVnlJRDA5SUdGeVl6UXVRV1JrY21WemN5aEhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpLUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UQXpMVEV3TkFvZ0lDQWdMeThnSXlCYVpYSnZJR0ZrWkhKbGMzTWdQU0J2Y0dWdUlHSnZkVzUwZVRzZ1puSmxaV3hoYm1ObGNpQmpiR0ZwYlhNZ2IyNGdZV05qWlhCMFgzUmhjMnN1Q2lBZ0lDQXZMeUJwWmlCdWIzUWdjMlZzWmk1cGMxOXZjR1Z1WDJaeVpXVnNZVzVqWlhJb1puSmxaV3hoYm1ObGNpazZDaUFnSUNCaWJub2dZM0psWVhSbFgyVnpZM0p2ZDE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdaeVpXVnNZVzVqWlhJdWJtRjBhWFpsSUNFOUlGUjRiaTV6Wlc1a1pYSXNJQ0ptY21WbGJHRnVZMlZ5SUcxMWMzUWdaR2xtWm1WeUlHWnliMjBnWTJ4cFpXNTBJZ29nSUNBZ1pHbG5JRFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWm5KbFpXeGhibU5sY2lCdGRYTjBJR1JwWm1abGNpQm1jbTl0SUdOc2FXVnVkQW9LWTNKbFlYUmxYMlZ6WTNKdmQxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJR05zYVdWdWREMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaGhiVzkxYm5SZmJtRjBhWFpsS1N3S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR055WldGMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UQTNMVEV4TmdvZ0lDQWdMeThnYzJWc1ppNWxjMk55YjNkelcydGxlVjBnUFNCRmMyTnliM2RTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnWTJ4cFpXNTBQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGJHRnVZMlZ5UFdaeVpXVnNZVzVqWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLR0Z0YjNWdWRGOXVZWFJwZG1VcExBb2dJQ0FnTHk4Z0lDQWdJSFZ6WkdOZllYTnpaWFJmYVdROWRYTmtZMTloYzNObGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwTmpRb1UxUkJWRlZUWDA5UVJVNHBMQW9nSUNBZ0x5OGdJQ0FnSUdsd1puTmZhR0Z6YUQxaGNtTTBMbE4wY21sdVp5Z2lJaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnWkdWaFpHeHBibVU5WkdWaFpHeHBibVVzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3Tm1FS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklHbHdabk5mYUdGemFEMWhjbU0wTGxOMGNtbHVaeWdpSWlrc0NpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRBM0xURXhOZ29nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2R6VzJ0bGVWMGdQU0JGYzJOeWIzZFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZMnhwWlc1MFBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsYkdGdVkyVnlQV1p5WldWc1lXNWpaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZEY5dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lIVnpaR05mWVhOelpYUmZhV1E5ZFhOa1kxOWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBOalFvVTFSQlZGVlRYMDlRUlU0cExBb2dJQ0FnTHk4Z0lDQWdJR2x3Wm5OZmFHRnphRDFoY21NMExsTjBjbWx1WnlnaUlpa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZoWkd4cGJtVTlaR1ZoWkd4cGJtVXNDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNWpjbVZoZEdWZlpYTmpjbTkzWDNWelpHTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZaWE5qY205M1gzVnpaR002Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdZWE56WlhKMElHdGxlU0J1YjNRZ2FXNGdjMlZzWmk1bGMyTnliM2R6TENBaWRHRnphMTlwWkNCaGJISmxZV1I1SUdWNGFYTjBjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTlRjek5qTUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIUmhjMnRmYVdRZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1lXMXZkVzUwWDI1aGRHbDJaU0E5SUdaMWJtUXVZWE56WlhSZllXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRGOXVZWFJwZG1VZ1BpQXdMQ0FpWVcxdmRXNTBJRzExYzNRZ1ltVWdQaUF3SWdvZ0lDQWdZWE56WlhKMElDOHZJR0Z0YjNWdWRDQnRkWE4wSUdKbElENGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWljR0Y1SUhSdklHRndjQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNUlIUnZJR0Z3Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UTTBDaUFnSUNBdkx5QmhjM05sY25RZ1puVnVaQzV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2l3Z0luQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxMWMzUWdZbVVnWTJGc2JHVnlJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0JpWlNCallXeHNaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdaMWJtUXVZWE56WlhSZlkyeHZjMlZmZEc4Z1BUMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeXdnSW01dklHTnNiM05sSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRU5zYjNObFZHOEtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJqYkc5elpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVE0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdablZ1WkM1eVpXdGxlVjkwYnlBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0FpYm04Z2NtVnJaWGtpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbGEyVjVWRzhLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YnlCeVpXdGxlUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNTRabVZ5WDJGemMyVjBMbWxrSUQwOUlIVnpaR05mWVhOelpYUmZhV1F1Ym1GMGFYWmxMQ0FpWVhOelpYUWdiV2x6YldGMFkyZ2lDaUFnSUNCbmRIaHVjeUJZWm1WeVFYTnpaWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnYldsemJXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCeVpYUjFjbTRnWm5KbFpXeGhibU5sY2lBOVBTQmhjbU0wTGtGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnYVdZZ2JtOTBJSE5sYkdZdWFYTmZiM0JsYmw5bWNtVmxiR0Z1WTJWeUtHWnlaV1ZzWVc1alpYSXBPZ29nSUNBZ1ltNTZJR055WldGMFpWOWxjMk55YjNkZmRYTmtZMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnWVhOelpYSjBJR1p5WldWc1lXNWpaWEl1Ym1GMGFYWmxJQ0U5SUZSNGJpNXpaVzVrWlhJc0lDSm1jbVZsYkdGdVkyVnlJRzExYzNRZ1pHbG1abVZ5SUdaeWIyMGdZMnhwWlc1MElnb2dJQ0FnWkdsbklEUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdabkpsWld4aGJtTmxjaUJ0ZFhOMElHUnBabVpsY2lCbWNtOXRJR05zYVdWdWRBb0tZM0psWVhSbFgyVnpZM0p2ZDE5MWMyUmpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnWTJ4cFpXNTBQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLR0Z0YjNWdWRGOXVZWFJwZG1VcExBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUwT1FvZ0lDQWdMeThnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOREl0TVRVeENpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQzTmJhMlY1WFNBOUlFVnpZM0p2ZDFKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCamJHbGxiblE5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVnNZVzVqWlhJOVpuSmxaV3hoYm1ObGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZWEpqTkM1VlNXNTBOalFvWVcxdmRXNTBYMjVoZEdsMlpTa3NDaUFnSUNBdkx5QWdJQ0FnZFhOa1kxOWhjM05sZEY5cFpEMTFjMlJqWDJGemMyVjBYMmxrTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RMk5DaFRWRUZVVlZOZlQxQkZUaWtzQ2lBZ0lDQXZMeUFnSUNBZ2FYQm1jMTlvWVhOb1BXRnlZelF1VTNSeWFXNW5LQ0lpS1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXRmtiR2x1WlQxa1pXRmtiR2x1WlN3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBMllRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdhWEJtYzE5b1lYTm9QV0Z5WXpRdVUzUnlhVzVuS0NJaUtTd0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5ESXRNVFV4Q2lBZ0lDQXZMeUJ6Wld4bUxtVnpZM0p2ZDNOYmEyVjVYU0E5SUVWelkzSnZkMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JqYkdsbGJuUTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWc1lXNWpaWEk5Wm5KbFpXeGhibU5sY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9ZVzF2ZFc1MFgyNWhkR2wyWlNrc0NpQWdJQ0F2THlBZ0lDQWdkWE5rWTE5aGMzTmxkRjlwWkQxMWMyUmpYMkZ6YzJWMFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblEyTkNoVFZFRlVWVk5mVDFCRlRpa3NDaUFnSUNBdkx5QWdJQ0FnYVhCbWMxOW9ZWE5vUFdGeVl6UXVVM1J5YVc1bktDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldGa2JHbHVaVDFrWldGa2JHbHVaU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHRnNaMjlsWVhObFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1RmMyTnliM2REYjI1MGNtRmpkQzVoWTJObGNIUmZkR0Z6YTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmpZMlZ3ZEY5MFlYTnJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUxTndvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWxjMk55YjNkelcydGxlVjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROalUzTXpZekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTmpjbTkzY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUxTnkweE5UZ0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBOalFvVTFSQlZGVlRYMDlRUlU0cExDQWlibTkwSUU5UVJVNGlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZUMUJGVGlrc0lDSnViM1FnVDFCRlRpSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCUFVFVk9DaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUdsbUlITmxiR1l1YVhOZmIzQmxibDltY21WbGJHRnVZMlZ5S0hKbFkyOXlaQzVtY21WbGJHRnVZMlZ5S1RvS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCbWNtVmxiR0Z1WTJWeUlEMDlJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektRb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCcFppQnpaV3htTG1selgyOXdaVzVmWm5KbFpXeGhibU5sY2loeVpXTnZjbVF1Wm5KbFpXeGhibU5sY2lrNkNpQWdJQ0JpZWlCaFkyTmxjSFJmZEdGemExOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBaFBTQnlaV052Y21RdVkyeHBaVzUwTG01aGRHbDJaU3dnSW1aeVpXVnNZVzVqWlhJZ2JYVnpkQ0JrYVdabVpYSWdabkp2YlNCamJHbGxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdaeVpXVnNZVzVqWlhJZ2JYVnpkQ0JrYVdabVpYSWdabkp2YlNCamJHbGxiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFMk1nb2dJQ0FnTHk4Z2NtVmpiM0prTG1aeVpXVnNZVzVqWlhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJR1JwWnlBeENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnlaWEJzWVdObE1pQXpNZ29nSUNBZ1luVnllU0F5Q2dwaFkyTmxjSFJmZEdGemExOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZRVU5EUlZCVVJVUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ESUtJQ0FnSUhKbGNHeGhZMlV5SURnd0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOamNLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1lXTmpaWEIwWDNSaGMydGZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSEpsWTI5eVpDNW1jbVZsYkdGdVkyVnlMbTVoZEdsMlpTd2dJbTl1YkhrZ1puSmxaV3hoYm1ObGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1puSmxaV3hoYm1ObGNnb2dJQ0FnWWlCaFkyTmxjSFJmZEdGemExOWhablJsY2w5cFpsOWxiSE5sUURRS0Nnb3ZMeUJoYkdkdlpXRnpaVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVSWE5qY205M1EyOXVkSEpoWTNRdWMzVmliV2wwWDNkdmNtdGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKdGFYUmZkMjl5YXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UY3pDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5UY3pOak1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6WTNKdmQzTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE56TXRNVGMwQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtVnpZM0p2ZDNOYmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlEwTkZVRlJGUkNrc0lDSnViM1FnUVVORFJWQlVSVVFpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlEwTkZVRlJGUkNrc0lDSnViM1FnUVVORFJWQlVSVVFpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNZ29nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJRUZEUTBWUVZFVkVDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlISmxZMjl5WkM1bWNtVmxiR0Z1WTJWeUxtNWhkR2wyWlN3Z0ltOXViSGtnWm5KbFpXeGhibU5sY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWm5KbFpXeGhibU5sY2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QmhjM05sY25RZ2FYQm1jMTlqYVdRdVlubDBaWE11YkdWdVozUm9JRDRnTUN3Z0ltbHdabk5mWTJsa0lISmxjWFZwY21Wa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhWEJtYzE5amFXUWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUzT0FvZ0lDQWdMeThnY21WamIzSmtMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0ZOVVFWUlZVMTlUVlVKTlNWUlVSVVFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNd29nSUNBZ2NtVndiR0ZqWlRJZ09EQUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUzT1FvZ0lDQWdMeThnY21WamIzSmtMbWx3Wm5OZmFHRnphQ0E5SUdsd1puTmZZMmxrQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdHJaWGxkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVjbVZxWldOMFgzZHZjbXRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXcGxZM1JmZDI5eWF6b0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakl4T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNak1LSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxjMk55YjNkeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpJekxUSXlOQW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1bGMyTnliM2R6VzJ0bGVWMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNoVFZFRlVWVk5mVTFWQ1RVbFVWRVZFS1N3Z0ltNXZkQ0JUVlVKTlNWUlVSVVFpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5VFZVSk5TVlJVUlVRcExDQWlibTkwSUZOVlFrMUpWRlJGUkNJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnVTFWQ1RVbFVWRVZFQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSEpsWTI5eVpDNWpiR2xsYm5RdWJtRjBhWFpsTENBaWIyNXNlU0JqYkdsbGJuUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR05zYVdWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNakkyQ2lBZ0lDQXZMeUJ6Wld4bUxsOXlaV1oxYm1SZlkyeHBaVzUwS0hKbFkyOXlaQ3dnYTJWNUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJmY21WbWRXNWtYMk5zYVdWdWRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNWhjSEJ5YjNabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3Y205MlpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNeklLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNekl0TWpNekNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbVZ6WTNKdmQzTmJhMlY1WFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREWTBLRk5VUVZSVlUxOVRWVUpOU1ZSVVJVUXBMQ0FpYm05MElGTlZRazFKVkZSRlJDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREWTBLRk5VUVZSVlUxOVRWVUpOU1ZSVVJVUXBMQ0FpYm05MElGTlZRazFKVkZSRlJDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBekNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ1UxVkNUVWxVVkVWRUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZMnhwWlc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNell0TWpNM0NpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRIVnpJRDBnWVhKak5DNVZTVzUwTmpRb1UxUkJWRlZUWDBGUVVGSlBWa1ZFS1FvZ0lDQWdMeThnYzJWc1ppNWxjMk55YjNkelcydGxlVjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNellLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2hUVkVGVVZWTmZRVkJRVWs5V1JVUXBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd05Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNak0yTFRJek53b2dJQ0FnTHk4Z2NtVmpiM0prTG5OMFlYUjFjeUE5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlVGQlNUMVpGUkNrS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdHJaWGxkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXlPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWVd4bmIyVmhjMlZmWlhOamNtOTNMbU52Ym5SeVlXTjBMa1Z6WTNKdmQwTnZiblJ5WVdOMExuSmxiR1ZoYzJWZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxiR1ZoYzJWZmNHRjViV1Z1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXpPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU5ETUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhOamNtOTNjMXRyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56TTJNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU5ETXRNalEwQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtVnpZM0p2ZDNOYmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtGTlVRVlJWVTE5QlVGQlNUMVpGUkNrc0lDSnViM1FnUVZCUVVrOVdSVVFpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpRMENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNoVFZFRlVWVk5mUVZCUVVrOVdSVVFwTENBaWJtOTBJRUZRVUZKUFZrVkVJZ29nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EUUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQkJVRkJTVDFaRlJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNalExQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCeVpXTnZjbVF1WTJ4cFpXNTBMbTVoZEdsMlpTd2dJbTl1YkhrZ1kyeHBaVzUwSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR05zYVdWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNalEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVnUGlBd0xDQWlibThnWm5WdVpITWlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1puVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJME9Rb2dJQ0FnTHk4Z1puSmxaV3hoYm1ObGNpQTlJSEpsWTI5eVpDNW1jbVZsYkdGdVkyVnlMbTVoZEdsMlpRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkxTUFvZ0lDQWdMeThnWkdWc0lITmxiR1l1WlhOamNtOTNjMXRyWlhsZENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TlRFS0lDQWdJQzh2SUhObGJHWXVYM05sYm1SZlpYTmpjbTkzWDNCaGVXOTFkQ2htY21WbGJHRnVZMlZ5TENCeVpXTnZjbVF1WVcxdmRXNTBMQ0J5WldOdmNtUXVkWE5rWTE5aGMzTmxkRjlwWkNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOXpaVzVrWDJWelkzSnZkMTl3WVhsdmRYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakl6T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXeG5iMlZoYzJWZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtWelkzSnZkME52Ym5SeVlXTjBMbkpsWm5WdVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWm5WdVpEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkxTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TlRjS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVaWE5qY205M2MxdHJaWGxkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkxTnpNMk13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WelkzSnZkM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TlRjdE1qVTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlISmxZMjl5WkM1amJHbGxiblF1Ym1GMGFYWmxMQ0FpYjI1c2VTQmpiR2xsYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVqYkdsbGJuUXVibUYwYVhabExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWTJ4cFpXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TmpBS0lDQWdJQzh2SUhOMFlYUjFjeUE5SUhKbFkyOXlaQzV6ZEdGMGRYTXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPREFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkyTVFvZ0lDQWdMeThnWkdWaFpHeHBibVVnUFNCeVpXTnZjbVF1WkdWaFpHeHBibVV1Ym1GMGFYWmxDaUFnSUNCd2RYTm9hVzUwSURrNENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnYm05M0lEMGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSTJOZ29nSUNBZ0x5OGdjM1JoZEhWeklEMDlJRk5VUVZSVlUxOVBVRVZPSUc5eUlITjBZWFIxY3lBOVBTQlRWRUZVVlZOZlFVTkRSVkJVUlVRZ2IzSWdjM1JoZEhWeklEMDlJRk5VUVZSVlUxOVRWVUpOU1ZSVVJVUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbFpuVnVaRjlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsWm5WdVpGOWliMjlzWDNSeWRXVkFOQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUhKbFpuVnVaRjlpYjI5c1gyWmhiSE5sUURVS0NuSmxablZ1WkY5aWIyOXNYM1J5ZFdWQU5Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncHlaV1oxYm1SZlltOXZiRjl0WlhKblpVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpZNENpQWdJQ0F2THlCaGMzTmxjblFnYVhOZmNtVm1kVzVrWVdKc1pWOXpkR0YwZFhNc0lDSnlaV1oxYm1RZ2JtOTBJR0ZzYkc5M1pXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVm1kVzVrSUc1dmRDQmhiR3h2ZDJWa0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOamt0TWpjd0NpQWdJQ0F2THlBaklFRm1kR1Z5SUZOVlFrMUpWRlJGUkN3Z2NtVnhkV2x5WlNCa1pXRmtiR2x1WlNCMGJ5Qm9ZWFpsSUhCaGMzTmxaQW9nSUNBZ0x5OGdhV1lnYzNSaGRIVnpJRDA5SUZOVVFWUlZVMTlUVlVKTlNWUlVSVVE2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVm1kVzVrWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpjeENpQWdJQ0F2THlCaGMzTmxjblFnYm05M0lENDlJR1JsWVdSc2FXNWxMQ0FpWkdWaFpHeHBibVVnYm05MElISmxZV05vWldRaUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR1JsWVdSc2FXNWxJRzV2ZENCeVpXRmphR1ZrQ2dweVpXWjFibVJmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpjekNpQWdJQ0F2THlCelpXeG1MbDl5WldaMWJtUmZZMnhwWlc1MEtISmxZMjl5WkN3Z2EyVjVLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQmpZV3hzYzNWaUlGOXlaV1oxYm1SZlkyeHBaVzUwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXWjFibVJmWW05dmJGOW1ZV3h6WlVBMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY21WbWRXNWtYMkp2YjJ4ZmJXVnlaMlZBTmdvS0NpOHZJR0ZzWjI5bFlYTmxYMlZ6WTNKdmR5NWpiMjUwY21GamRDNUZjMk55YjNkRGIyNTBjbUZqZEM1blpYUmZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOMFlYUjFjem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOemtLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOemt0TWpnd0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbVZ6WTNKdmQzTmJhMlY1WFM1amIzQjVLQ2tLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaV052Y21RdWMzUmhkSFZ6Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCaGJHZHZaV0Z6WlY5bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVYM05sYm1SZlpYTmpjbTkzWDNCaGVXOTFkQ2h5WldObGFYWmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lHRnpjMlYwWDJsa09pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gzTmxibVJmWlhOamNtOTNYM0JoZVc5MWREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakU0TWkweE9EZ0tJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDNObGJtUmZaWE5qY205M1gzQmhlVzkxZENnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYVdRNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hPVEFLSUNBZ0lDOHZJSEJoZVc5MWRDQTlJR0Z0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx2ZFhRZ1BpQXdMQ0FpYm04Z1puVnVaSE1pQ2lBZ0lDQmhjM05sY25RZ0x5OGdibThnWm5WdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakU1TWdvZ0lDQWdMeThnWVhCd0lEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakU1TXdvZ0lDQWdMeThnWVhaaGFXeGhZbXhsSUQwZ1lYQndMbUpoYkdGdVkyVWdMU0JoY0hBdWJXbHVYMkpoYkdGdVkyVUtJQ0FnSUdSMWNBb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSQ1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJSE4zWVhBS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE9UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGRtRnBiR0ZpYkdVZ1BqMGdjR0Y1YjNWMExDQWlhVzV6ZFdabWFXTnBaVzUwSUdWelkzSnZkeUJzYVhGMWFXUnBkSGtpQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVjM1ZtWm1samFXVnVkQ0JsYzJOeWIzY2diR2x4ZFdsa2FYUjVDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUdGemMyVjBYMjVoZEdsMlpTQTlJR0Z6YzJWMFgybGtMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakU1TndvZ0lDQWdMeThnYVdZZ1lYTnpaWFJmYm1GMGFYWmxJRDRnTURvS0lDQWdJR0o2SUY5elpXNWtYMlZ6WTNKdmQxOXdZWGx2ZFhSZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakU1T0MweU1ETUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLR0Z6YzJWMFgyNWhkR2wyWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTVPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1ESUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE9UZ3RNakF6Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoaGMzTmxkRjl1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWEpsWTJWcGRtVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNncGZjMlZ1WkY5bGMyTnliM2RmY0dGNWIzVjBYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qQTFMVEl3T1FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEpsWTJWcGRtVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNRFVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJd05TMHlNRGtLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1YjNWMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdGc1oyOWxZWE5sWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVGYzJOeWIzZERiMjUwY21GamRDNWZjbVZtZFc1a1gyTnNhV1Z1ZENoeVpXTnZjbVE2SUdKNWRHVnpMQ0JyWlhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gzSmxablZ1WkY5amJHbGxiblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1URXRNakV5Q2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlGOXlaV1oxYm1SZlkyeHBaVzUwS0hObGJHWXNJSEpsWTI5eVpEb2dSWE5qY205M1VtVmpiM0prTENCclpYazZJRUo1ZEdWektTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1WVcxdmRXNTBMbTVoZEdsMlpTQStJREFzSUNKdWJ5Qm1kVzVrY3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQTJOQ0E0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdablZ1WkhNS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdZMnhwWlc1MElEMGdjbVZqYjNKa0xtTnNhV1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TVRZS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1WelkzSnZkM05iYTJWNVhRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek0yTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNakUzQ2lBZ0lDQXZMeUJ6Wld4bUxsOXpaVzVrWDJWelkzSnZkMTl3WVhsdmRYUW9ZMnhwWlc1MExDQnlaV052Y21RdVlXMXZkVzUwTENCeVpXTnZjbVF1ZFhOa1kxOWhjM05sZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0EzTWlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUY5elpXNWtYMlZ6WTNKdmQxOXdZWGx2ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWUhBMlZ6WXdnQUFBQUFBQUFBQXcxMWMyUmpYMkZ6YzJWMFgybGtDZ0FBQUFBQUFBQUJBR29DQUFBSUFBQUFBQUFBQUFJSUFBQUFBQUFBQUFReEdFQUFBeW9pWnpFYlFRQmNNUmtVUkRFWVJJSUxCR2NWUS9rRTQ4M3ZPd1FDQnZXU0JDQWt0RjBFQ0p6d0pRUmlYQ0VUQkRaZWlCSUVTazk2OEFSaTh3RlNCQ0NRZ0NVRWlOLzA1allhQUk0TEFBa0FIUUJBQU5jQmR3SFVBaU1DVVFKNkFyMERJUUF4R1JReEdCUVFRellhQVVrVkpCSkVNUUF5Q1JKRUZ5cE1aeU5ETmhvQlNSVWtFa1FYTVFBeUNSSkVzVElLSXJJU3NoU3lFWUVFc2hBaXNnR3pJME0yR2dGSklsa2xDRXNCRlJKRU5ob0NTVTRDU1JXQklCSkVOaG9EU1U0REZTUVNSRFlhQkVsT0F4VWtFa1F4RmlNSlNUZ1FJeEpFS0U4RFVFbE9BNzFGQVJSRVNUZ0lTVTREUkVrNEJ6SUtFa1JKT0FBeEFCSkVTVGdKTWdNU1JEZ2dNZ01TUkRJREVrQUFCa3NFTVFBVFJERUFTd0VXTWdjV1R3SkxCMUJQQWxCTEJGQXJVRXhRU3dSUUp3UlFTd0pKdkVoTXZ5TkROaG9CU1NKWkpRaExBUlVTUkRZYUFrbE9Ba2tWZ1NBU1JEWWFBMGxPQXhVa0VrUTJHZ1JKVGdOSkZTUVNSREVXSXdsSk9CQ0JCQkpFS0U4RVVFbE9CTDFGQVJSRVNUZ1NTVTRFUkVrNEZESUtFa1JKT0FBeEFCSkVTVGdWTWdNU1JFazRJRElERWtRNEVVd1hFa1F5QXhKQUFBWkxCREVBRTBReEFFc0JGaklIRms4Q1N3ZFFUd0pRU3dSUUsxQk1VRXNFVUNjRVVFc0NTYnhJVEw4alF6WWFBVWtpV1NVSVN3RVZFa1FvVEZCSEFyNU1UZ0pFU1lGUUpMcUFDQUFBQUFBQUFBQUJxRVNCSUVtNlNUSURFa0VBSVRFQVN3TWlnU0M2RTBSTEFURUFYQ0JGQWtzQkp3VmNVRXNEU2J4SVRMOGpRekVBU3dFU1JFTC82RFlhQVVraVdTVUlTd0VWRWtRMkdnSkpJbGtsQ0VzQkZVbFBBaEpFS0U4RFVFbStSRXNCZ1ZBa3VpY0ZxRVF4QUVzQ2dTQkp1aEpFVHdKRUtWeFFTWUZZV1NKTVdFOENVRXNCdkVpL0kwTTJHZ0ZKSWxrbENFc0JGUkpFS0VzQlVFbStSRXNCZ1ZBa3VpbW9SREVBVHdJaWdTQzZFa1JNaUFFMFNDTkROaG9CU1NKWkpRaExBUlVTUkNoTVVFbUJVQ1M2S2FoRU1RQkxBU0tCSUxvU1JJRlFKd2E3STBNMkdnRkpJbGtsQ0VzQkZSSkVLRXhRU1lGUUpMb25CcWhFTVFCTEFTS0JJTG9TUkVtQlFDUzZTUmRFU3dHQklFbTZTd0s4U0U4Q2dVZ2t1a3hPQW9nQWhTTkROaG9CUndJaVdTVUlTd0VWRWtRb1RGQkp2a3hPQWtReEFFc0JJb0VndWhKRVNZRlFKTG9YU1U4Q2dXSWt1aGRNTWdkTUl4SkFBQTlMQWlVU1FBQUlTd0tCQXhKQkFCa2pSRXNDZ1FNU1FRQUZTVXNDRDBSTEEwc0ZpQUJvU0NORElrTC81RFlhQVVraVdTVUlTd0VWRWtRb1RGQ0JVQ1M2Z0FRVkgzeDFURkN3STBPS0F3Q0wvaGRIQWtReUNrbHpBRVJNY3dGRUNRNUVpLzhYU1U0Q1FRQVVzYklTaS8yeUZJc0FzaEdCQkxJUUlySUJzNG14c2dpTC9iSUhJN0lRSXJJQnM0bUtBZ0dML2xkQUNJditnVUJiUkl2K1Z3QWdLSXYvVUx4SWkvNVhTQWhNVGdLSS81cUwvb2s9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
