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

namespace Arc56.Generated.nickthelegend.irion_contracts.MerchantEscrow_6cb33bfe
{


    public class MerchantEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MerchantEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EscrowData : AVMObjectType
            {
                public byte[] Merchant { get; set; }

                public ulong Amount { get; set; }

                public ulong ReleaseRound { get; set; }

                public ulong Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMerchant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vMerchant.From(Merchant);
                    ret.AddRange(vMerchant.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReleaseRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReleaseRound.From(ReleaseRound);
                    ret.AddRange(vReleaseRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EscrowData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMerchant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vMerchant.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMerchant = vMerchant.ToValue();
                    if (valueMerchant is byte[] vMerchantValue) { ret.Merchant = vMerchantValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReleaseRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReleaseRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReleaseRound = vReleaseRound.ToValue();
                    if (valueReleaseRound is ulong vReleaseRoundValue) { ret.ReleaseRound = vReleaseRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowData);
                }
                public bool Equals(EscrowData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowData left, EscrowData right)
                {
                    return EqualityComparer<EscrowData>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowData left, EscrowData right)
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
        /// <param name="bnpl_app_id"> </param>
        /// <param name="usdc_asset_id"> </param>
        public async Task Bootstrap(ulong bnpl_app_id, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 239, 5, 14 };
            var bnpl_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bnpl_app_idAbi.From(bnpl_app_id);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, bnpl_app_idAbi, usdc_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong bnpl_app_id, ulong usdc_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 239, 5, 14 };
            var bnpl_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bnpl_app_idAbi.From(bnpl_app_id);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bnpl_app_idAbi, usdc_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        /// <param name="merchant"> </param>
        /// <param name="payment"> </param>
        public async Task CreateEscrow(AssetTransferTransaction payment, ulong loan_id, Algorand.Address merchant, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 26, 42, 156, 216 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); merchantAbi.From(merchant);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi, merchantAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(AssetTransferTransaction payment, ulong loan_id, Algorand.Address merchant, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 26, 42, 156, 216 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); merchantAbi.From(merchant);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi, merchantAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task ReleaseToMerchant(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 57, 80, 100 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleaseToMerchant_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 57, 80, 100 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        /// <param name="borrower"> </param>
        public async Task RefundToBorrower(ulong loan_id, Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 183, 23, 155 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundToBorrower_Transactions(ulong loan_id, Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 183, 23, 155 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task<Structs.EscrowData> GetEscrow(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 225, 90, 70 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.SimApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EscrowData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEscrow_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 225, 90, 70 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVyY2hhbnRFc2Nyb3ciLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRXNjcm93RGF0YSI6W3sibmFtZSI6Im1lcmNoYW50IiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWxlYXNlX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibnBsX2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19hc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiTm9PcCIsIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX2VzY3JvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVyY2hhbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX3RvX21lcmNoYW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kX3RvX2JvcnJvd2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZXNjcm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJFc2Nyb3dEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0OF0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMSwzOTcsNTA2XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOSw0MDVdLCJlcnJvck1lc3NhZ2UiOiJFc2Nyb3cgbm90IHBlbmRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDRdLCJlcnJvck1lc3NhZ2UiOiJGdW5kcyBtdXN0IGdvIHRvIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzN10sImVycm9yTWVzc2FnZSI6Ik11c3Qgc2VuZCBVU0RDIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgb25lIG9mIE5vT3AsIE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjoiU2V0dGxlbWVudCBwZXJpb2Qgbm90IGNvbXBsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDI1NCwzMzgsNDI0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2LDM5Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDIsMTUxLDIwNSwyOTYsMzgyLDQ1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXdJREVnTVRnS0lDQWdJR0o1ZEdWallteHZZMnNnSW5WelpHTmZZWE56WlhSZmFXUWlJQ0p6WlhSMGJHVnRaVzUwWDJSbGJHRjVYM0p2ZFc1a2N5SWdNSGd3TURGaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTlpYSmphR0Z1ZEVWelkzSnZkeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGhpWldZd05UQmxJQzh2SUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWW05dmRITjBjbUZ3WDNKdmRYUmxRRElLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV1Z5WTJoaGJuUkZjMk55YjNjZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRBS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneFlUSmhPV05rT0NBd2VHUm1NemsxTURZMElEQjRNMlppTnpFM09XSWdNSGcwTjJVeE5XRTBOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjlsYzJOeWIzY29kV2x1ZERZMExHRmtaSEpsYzNNc1lYaG1aWElwZG05cFpDSXNJRzFsZEdodlpDQWljbVZzWldGelpWOTBiMTl0WlhKamFHRnVkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVm1kVzVrWDNSdlgySnZjbkp2ZDJWeUtIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5bGMyTnliM2NvZFdsdWREWTBLU2hpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsWDJWelkzSnZkeUJ5Wld4bFlYTmxYM1J2WDIxbGNtTm9ZVzUwSUhKbFpuVnVaRjkwYjE5aWIzSnliM2RsY2lCblpYUmZaWE5qY205M0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5aWEpqYUdGdWRFVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSak5XTTJNV0poSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRFS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzblRtOVBjQ2RkTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZiM1J6ZEhKaGNGOXliM1YwWlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGNtTm9ZVzUwWDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjA1dlQzQW5MQ0FuVDNCMFNXNG5YU3dnYjI1RGNtVmhkR1U2SUNkaGJHeHZkeWNnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J6YUd3S0lDQWdJSEIxYzJocGJuUWdNeUF2THlBekNpQWdJQ0FtQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnYjI1bElHOW1JRTV2VDNBc0lFOXdkRWx1Q2lBZ0lDQmlJR0p2YjNSemRISmhjQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeVkyaGhiblJGYzJOeWIzY3VZbTl2ZEhOMGNtRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBbkxDQW5UM0IwU1c0blhTd2diMjVEY21WaGRHVTZJQ2RoYkd4dmR5Y2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWW01d2JGOWhjSEJmYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZbTV3YkY5aGNIQmZhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIUm9hWE11WW01d2JGOWhjSEJmYVdRdWRtRnNkV1VnUFNCaWJuQnNYMkZ3Y0Y5cFpBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QnpaWFIwYkdWdFpXNTBYMlJsYkdGNVgzSnZkVzVrY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljMlYwZEd4bGJXVnVkRjlrWld4aGVWOXliM1Z1WkhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJSFJvYVhNdWMyVjBkR3hsYldWdWRGOWtaV3hoZVY5eWIzVnVaSE11ZG1Gc2RXVWdQU0JUUlZSVVRFVk5SVTVVWDBSRlRFRlpYMUpQVlU1RVV3b2dJQ0FnY0hWemFHbHVkQ0F4TURBd0lDOHZJREV3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSFZ6WkdOZllYTnpaWFJmYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WkdOZllYTnpaWFJmYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJvYVhNdWRYTmtZMTloYzNObGRGOXBaQzUyWVd4MVpTQTlJSFZ6WkdOZllYTnpaWFJmYVdRS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGNtTm9ZVzUwWDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzTFRVeUNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJSFZ6WkdOZllYTnpaWFJmYVdRc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWEpqYUdGdWRGOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjdE5USUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nZFhOa1kxOWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGemMyVjBRVzF2ZFc1ME9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGN0TlRJS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dkWE5rWTE5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25UbTlQY0Njc0lDZFBjSFJKYmlkZExDQnZia055WldGMFpUb2dKMkZzYkc5M0p5QjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFdWeVkyaGhiblJGYzJOeWIzY3VZM0psWVhSbFgyVnpZM0p2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5bGMyTnliM2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUdOdmJuTjBJSFZ6WkdNNklIVnBiblEyTkNBOUlIUm9hWE11ZFhOa1kxOWhjM05sZEY5cFpDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWEpqYUdGdWRGOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2RYTmtZMTloYzNObGRGOXBaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmtZMTloYzNObGRGOXBaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWEpqYUdGdWRGOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1kyOXVjM1FnZFhOa1l6b2dkV2x1ZERZMElEMGdkR2hwY3k1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1NFptVnlRWE56WlhRdWFXUWdQVDA5SUhWelpHTXNJQ2ROZFhOMElITmxibVFnVlZORVF5Y3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnYzJWdVpDQlZVMFJEQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklIQmhlVzFsYm5RdVlYTnpaWFJTWldObGFYWmxjaTVpZVhSbGN5QTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXVZbmwwWlhNc0NpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekxUWTJDaUFnSUNBdkx5QmhjM05sY25Rb0NpQWdJQ0F2THlBZ0lIQmhlVzFsYm5RdVlYTnpaWFJTWldObGFYWmxjaTVpZVhSbGN5QTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lDZEdkVzVrY3lCdGRYTjBJR2R2SUhSdklHVnpZM0p2ZHljS0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJHZFc1a2N5QnRkWE4wSUdkdklIUnZJR1Z6WTNKdmR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGNtTm9ZVzUwWDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNWhjM05sZEVGdGIzVnVkQ0ErSUZWcGJuUTJOQ2d3S1N3Z0owRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01DY3BDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ1BpQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUhKbGJHVmhjMlZmY205MWJtUTZJRWRzYjJKaGJDNXliM1Z1WkNBcklIUm9hWE11YzJWMGRHeGxiV1Z1ZEY5a1pXeGhlVjl5YjNWdVpITXVkbUZzZFdVc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklITmxkSFJzWlcxbGJuUmZaR1ZzWVhsZmNtOTFibVJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpaWFIwYkdWdFpXNTBYMlJsYkdGNVgzSnZkVzVrY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNZ29nSUNBZ0x5OGdjbVZzWldGelpWOXliM1Z1WkRvZ1IyeHZZbUZzTG5KdmRXNWtJQ3NnZEdocGN5NXpaWFIwYkdWdFpXNTBYMlJsYkdGNVgzSnZkVzVrY3k1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamt0TnpRS0lDQWdJQzh2SUdOdmJuTjBJR1Z6WTNKdmR6b2dSWE5qY205M1JHRjBZU0E5SUhzS0lDQWdJQzh2SUNBZ2JXVnlZMmhoYm5RNklHMWxjbU5vWVc1MExtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhCaGVXMWxiblF1WVhOelpYUkJiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lISmxiR1ZoYzJWZmNtOTFibVE2SUVkc2IySmhiQzV5YjNWdVpDQXJJSFJvYVhNdWMyVjBkR3hsYldWdWRGOWtaV3hoZVY5eWIzVnVaSE11ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dSVk5EVWs5WFgxTlVRVlJWVTE5UVJVNUVTVTVITEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TVdFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdjM1JoZEhWek9pQkZVME5TVDFkZlUxUkJWRlZUWDFCRlRrUkpUa2NzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUxUYzBDaUFnSUNBdkx5QmpiMjV6ZENCbGMyTnliM2M2SUVWelkzSnZkMFJoZEdFZ1BTQjdDaUFnSUNBdkx5QWdJRzFsY21Ob1lXNTBPaUJ0WlhKamFHRnVkQzVpZVhSbGN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQndZWGx0Wlc1MExtRnpjMlYwUVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0J5Wld4bFlYTmxYM0p2ZFc1a09pQkhiRzlpWVd3dWNtOTFibVFnS3lCMGFHbHpMbk5sZEhSc1pXMWxiblJmWkdWc1lYbGZjbTkxYm1SekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCemRHRjBkWE02SUVWVFExSlBWMTlUVkVGVVZWTmZVRVZPUkVsT1J5d0tJQ0FnSUM4dklIMEtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklIUm9hWE11WlhOamNtOTNYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsSUQwZ1kyeHZibVVvWlhOamNtOTNLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTlpYSmphR0Z1ZEVWelkzSnZkeTV5Wld4bFlYTmxYM1J2WDIxbGNtTm9ZVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnNaV0Z6WlY5MGIxOXRaWEpqYUdGdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdOdmJuTjBJR1Z6WTNKdmR5QTlJR05zYjI1bEtIUm9hWE11WlhOamNtOTNYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3hMVGd5Q2lBZ0lDQXZMeUJqYjI1emRDQmxjMk55YjNjZ1BTQmpiRzl1WlNoMGFHbHpMbVZ6WTNKdmQxOWliM2hsY3loc2IyRnVYMmxrS1M1MllXeDFaU2tLSUNBZ0lDOHZJR0Z6YzJWeWRDaGxjMk55YjNjdWMzUmhkSFZ6SUQwOVBTQkZVME5TVDFkZlUxUkJWRlZUWDFCRlRrUkpUa2NzSUNkRmMyTnliM2NnYm05MElIQmxibVJwYm1jbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENobGMyTnliM2N1YzNSaGRIVnpJRDA5UFNCRlUwTlNUMWRmVTFSQlZGVlRYMUJGVGtSSlRrY3NJQ2RGYzJOeWIzY2dibTkwSUhCbGJtUnBibWNuS1FvZ0lDQWdZblJ2YVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVnpZM0p2ZHlCdWIzUWdjR1Z1WkdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGNtTm9ZVzUwWDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJoYzNObGNuUW9SMnh2WW1Gc0xuSnZkVzVrSUQ0OUlHVnpZM0p2ZHk1eVpXeGxZWE5sWDNKdmRXNWtMQ0FuVTJWMGRHeGxiV1Z1ZENCd1pYSnBiMlFnYm05MElHTnZiWEJzWlhSbEp5a0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRBZ0x5OGdNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWlhSMGJHVnRaVzUwSUhCbGNtbHZaQ0J1YjNRZ1kyOXRjR3hsZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdaWE5qY205M0xuTjBZWFIxY3lBOUlFVlRRMUpQVjE5VFZFRlVWVk5mVWtWTVJVRlRSVVFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ2NtVndiR0ZqWlRJZ01UZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlMwNE5nb2dJQ0FnTHk4Z1pYTmpjbTkzTG5OMFlYUjFjeUE5SUVWVFExSlBWMTlUVkVGVVZWTmZVa1ZNUlVGVFJVUUtJQ0FnSUM4dklIUm9hWE11WlhOamNtOTNYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsSUQwZ1kyeHZibVVvWlhOamNtOTNLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnTVRnS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0MwNU13b2dJQ0FnTHk4Z2FYUjRiaTVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdlR1psY2tGemMyVjBPaUIwYUdsekxuVnpaR05mWVhOelpYUmZhV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFRmpZMjkxYm5Rb1pYTmpjbTkzTG0xbGNtTm9ZVzUwS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJCYlc5MWJuUTZJR1Z6WTNKdmR5NWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lHWmxaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWEpqYUdGdWRGOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z2VHWmxja0Z6YzJWME9pQjBhR2x6TG5WelpHTmZZWE56WlhSZmFXUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QjFjMlJqWDJGemMyVjBYMmxrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFjMlJqWDJGemMyVjBYMmxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QjRabVZ5UVhOelpYUTZJSFJvYVhNdWRYTmtZMTloYzNObGRGOXBaQzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklFRmpZMjkxYm5Rb1pYTmpjbTkzTG0xbGNtTm9ZVzUwS1N3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nWlhOamNtOTNMbUZ0YjNWdWRDd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGd0T1RNS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dkR2hwY3k1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwS0dWelkzSnZkeTV0WlhKamFHRnVkQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBRVzF2ZFc1ME9pQmxjMk55YjNjdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNCbVpXVTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCbVpXVTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNExUa3pDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUhSb2FYTXVkWE5rWTE5aGMzTmxkRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dRV05qYjNWdWRDaGxjMk55YjNjdWJXVnlZMmhoYm5RcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nWlhOamNtOTNMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTlpYSmphR0Z1ZEVWelkzSnZkeTV5WldaMWJtUmZkRzlmWW05eWNtOTNaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXWjFibVJmZEc5ZlltOXljbTkzWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCamIyNXpkQ0JsYzJOeWIzY2dQU0JqYkc5dVpTaDBhR2x6TG1WelkzSnZkMTlpYjNobGN5aHNiMkZ1WDJsa0tTNTJZV3gxWlNrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQzA1T1FvZ0lDQWdMeThnWTI5dWMzUWdaWE5qY205M0lEMGdZMnh2Ym1Vb2RHaHBjeTVsYzJOeWIzZGZZbTk0WlhNb2JHOWhibDlwWkNrdWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9aWE5qY205M0xuTjBZWFIxY3lBOVBUMGdSVk5EVWs5WFgxTlVRVlJWVTE5UVJVNUVTVTVITENBblJYTmpjbTkzSUc1dmRDQndaVzVrYVc1bkp5a0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01UZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QmhjM05sY25Rb1pYTmpjbTkzTG5OMFlYUjFjeUE5UFQwZ1JWTkRVazlYWDFOVVFWUlZVMTlRUlU1RVNVNUhMQ0FuUlhOamNtOTNJRzV2ZENCd1pXNWthVzVuSnlrS0lDQWdJR0owYjJrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZjMk55YjNjZ2JtOTBJSEJsYm1ScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUdWelkzSnZkeTV6ZEdGMGRYTWdQU0JGVTBOU1QxZGZVMVJCVkZWVFgxSkZSbFZPUkVWRUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURFNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4TFRFd01nb2dJQ0FnTHk4Z1pYTmpjbTkzTG5OMFlYUjFjeUE5SUVWVFExSlBWMTlUVkVGVVZWTmZVa1ZHVlU1RVJVUUtJQ0FnSUM4dklIUm9hWE11WlhOamNtOTNYMkp2ZUdWektHeHZZVzVmYVdRcExuWmhiSFZsSUQwZ1kyeHZibVVvWlhOamNtOTNLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnTVRnS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURRdE1UQTVDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUhSb2FYTXVkWE5rWTE5aGMzTmxkRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZbTl5Y205M1pYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCbGMyTnliM2N1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWeVkyaGhiblJmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUI0Wm1WeVFYTnpaWFE2SUhSb2FYTXVkWE5rWTE5aGMzTmxkRjlwWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhWelpHTmZZWE56WlhSZmFXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WelpHTmZZWE56WlhSZmFXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklIUm9hWE11ZFhOa1kxOWhjM05sZEY5cFpDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nWlhOamNtOTNMbUZ0YjNWdWRDd0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05DMHhNRGtLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ2RHaHBjeTUxYzJSalgyRnpjMlYwWDJsa0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJpYjNKeWIzZGxjaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklHVnpZM0p2ZHk1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCbVpXVTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxjbU5vWVc1MFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05DMHhNRGtLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ2RHaHBjeTUxYzJSalgyRnpjMlYwWDJsa0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJpYjNKeWIzZGxjaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklHVnpZM0p2ZHk1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV1Z5WTJoaGJuUkZjMk55YjNjdVoyVjBYMlZ6WTNKdmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5bGMyTnliM2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1Z5WTJoaGJuUmZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFlLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVsYzJOeWIzZGZZbTk0WlhNb2JHOWhibDlwWkNrdVpYaHBjM1J6S1NCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR2RsZEY5bGMyTnliM2RmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFM0xURXlNZ29nSUNBZ0x5OGdjbVYwZFhKdUlGc0tJQ0FnSUM4dklDQWdRbmwwWlhNb0p5Y3BMQW9nSUNBZ0x5OGdJQ0JWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z1hRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhZVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtDbWRsZEY5bGMyTnliM2RmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxbGNtTm9ZVzUwUlhOamNtOTNMbWRsZEY5bGMyTnliM2RBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZaWE5qY205M1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJR052Ym5OMElHVnpZM0p2ZHlBOUlHTnNiMjVsS0hSb2FYTXVaWE5qY205M1gySnZlR1Z6S0d4dllXNWZhV1FwTG5aaGJIVmxLUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsY21Ob1lXNTBYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdaWE5qY205M0xtMWxjbU5vWVc1MExBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNENpQWdJQ0F2THlCbGMyTnliM2N1WVcxdmRXNTBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWprS0lDQWdJQzh2SUdWelkzSnZkeTV5Wld4bFlYTmxYM0p2ZFc1a0xBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRBZ0x5OGdNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGNtTm9ZVzUwWDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnWlhOamNtOTNMbk4wWVhSMWN5d0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWTE4eklDOHZJREU0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYSmphR0Z1ZEY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZdE1UTXhDaUFnSUNBdkx5QnlaWFIxY200Z1d3b2dJQ0FnTHk4Z0lDQmxjMk55YjNjdWJXVnlZMmhoYm5Rc0NpQWdJQ0F2THlBZ0lHVnpZM0p2ZHk1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUdWelkzSnZkeTV5Wld4bFlYTmxYM0p2ZFc1a0xBb2dJQ0FnTHk4Z0lDQmxjMk55YjNjdWMzUmhkSFZ6TEFvZ0lDQWdMeThnWFFvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01ERmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVnlZMmhoYm5SZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdJZ1oyVjBYMlZ6WTNKdmQxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhKamFHRnVkRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUV1Z5WTJoaGJuUkZjMk55YjNjdVoyVjBYMlZ6WTNKdmQwQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQ0FBQkVpWUREWFZ6WkdOZllYTnpaWFJmYVdRWGMyVjBkR3hsYldWdWRGOWtaV3hoZVY5eWIzVnVaSE1DQUJxQUJJdnZCUTQyR2dDT0FRQTlNUmtVUkRFWVFRQWtnZ1FFR2lxYzJBVGZPVkJrQkQrM0Y1c0VSK0ZhUmpZYUFJNEVBRnNBdGdFTUFWSUFnQVJNWEdHNk5ob0FqZ0VBQVFBa1F5UXhHWkNCQXhwRVFnQUFOaG9CU1JVaUVrUVhOaG9DU1JVaUVrUVhnQXRpYm5Cc1gyRndjRjlwWkU4Q1p5bUI2QWRuS0VzQlo3RXlDaU95RXJJVXNoR0JCTElRSTdJQnN5UkROaG9CU1JVaUVrUVhOaG9DU1JWSmdTQVNSREVXSkFsSk9CQ0JCQkpFSXlobFJFc0JPQkVTUkVrNEZESUtFa1E0RWtsRU1nWWpLV1ZFQ0U4Q0ZsY0dBazhEVUU4Q0ZpcE1VRThDRmxBakZsQk1VRXdXU2J4SVRMOGtRellhQVVrVkloSkVGeFpKdmtSTEFTVWl1aGNVUkRJR1N3S0JDaUs2Rnc5RUpCWk1Td0ZjRWs4Q0pVOER1N0VqS0dWRVN3RWpXVXNDRlVzRFRnSlNWd0lBVHdLQkFsdXlFcklVc2hHQkJMSVFJN0lCc3lSRE5ob0JTUlVpRWtRWE5ob0NTUldCSUJKRVRCWkp2a1JMQVNVaXVoY1VSSUVDRmt4TEFWd1NUd0lsVHdPN3NTTW9aVVJNZ1FKYnNoS3lFYklVZ1FTeUVDT3lBYk1rUXpZYUFVa1ZJaEpFRnhaSnZVVUJRQUFwZ0J3QUdnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBUVZIM3gxVEZDd0pFTkhBcjVFU1NOWlN3RVZVbGNDQUVzQmdRSWl1aGRMQW9FS0lyb1hUd01sSXJvWFN3TVZGbGNHQWs4RVVFOERGaXBNVUU4REZsQlBBaFpRVEZCQy83WT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
