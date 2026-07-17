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

namespace Arc56.Generated.DarshanKrishna_DK.CitadelAlgo.CitadelListingContract_d7fa1419
{


    //
    // 
    //    Citadel AI Moderator Listing Contract
    //
    //    This contract handles the creation of new AI moderator NFTs.
    //    A creator pays a listing fee and receives a unique NFT minted to their wallet.
    //    
    //    Key Features:
    //    - No hardcoded addresses - uses dynamic treasury from deployment
    //    - NFT goes directly to the user's wallet (not contract creator)
    //    - Proper transaction group validation
    //    - Testnet ready deployment
    //    
    //
    public class CitadelListingContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CitadelListingContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetContractStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetContractStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetContractStatsReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetContractStatsReturn);
                }
                public bool Equals(GetContractStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return EqualityComparer<GetContractStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploys the contract and sets the initial configuration.
        ///</summary>
        /// <param name="listing_fee">Fee in microAlgos to list a moderator (e.g., 100000 = 0.1 ALGO) </param>
        /// <param name="treasury">Address where fees should be sent </param>
        public async Task CreateApplication(ulong listing_fee, byte[] treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 16, 199, 120 };
            var listing_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_feeAbi.From(listing_fee);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); treasuryAbi.From(treasury);

            var result = await base.CallApp(new List<object> { abiHandle, listing_feeAbi, treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong listing_fee, byte[] treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 16, 199, 120 };
            var listing_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_feeAbi.From(listing_fee);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); treasuryAbi.From(treasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, listing_feeAbi, treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creates a new AI Moderator NFT and sends it to the caller's wallet.
        ///This must be called as part of an Atomic Transaction Group: 1. Payment transaction for the listing fee (index 0) 2. This app call (index 1)
        ///</summary>
        /// <param name="unit_name">Short unit name for the NFT (max 8 chars) </param>
        /// <param name="asset_name">Full name of the NFT (max 32 chars) </param>
        /// <param name="asset_url">URL pointing to NFT metadata </param>
        /// <param name="metadata_hash">Hash of the metadata (32 bytes) </param>
        /// <param name="description">Description of the AI moderator </param>
        public async Task<ulong> ListModerator(byte[] unit_name, byte[] asset_name, byte[] asset_url, byte[] metadata_hash, byte[] description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 160, 166, 7 };
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); unit_nameAbi.From(unit_name);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_nameAbi.From(asset_name);
            var asset_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_urlAbi.From(asset_url);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_hashAbi.From(metadata_hash);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); descriptionAbi.From(description);

            var result = await base.CallApp(new List<object> { abiHandle, unit_nameAbi, asset_nameAbi, asset_urlAbi, metadata_hashAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListModerator_Transactions(byte[] unit_name, byte[] asset_name, byte[] asset_url, byte[] metadata_hash, byte[] description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 160, 166, 7 };
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); unit_nameAbi.From(unit_name);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_nameAbi.From(asset_name);
            var asset_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_urlAbi.From(asset_url);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_hashAbi.From(metadata_hash);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); descriptionAbi.From(description);

            return await base.MakeTransactionList(new List<object> { abiHandle, unit_nameAbi, asset_nameAbi, asset_urlAbi, metadata_hashAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current listing fee in microAlgos
        ///</summary>
        public async Task<ulong> GetListingFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 51, 205, 11 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetListingFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 51, 205, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current treasury address
        ///</summary>
        public async Task<byte[]> GetTreasuryAddress(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 35, 236, 240 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetTreasuryAddress_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 35, 236, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract statistics
        ///</summary>
        public async Task<Structs.GetContractStatsReturn> GetContractStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 199, 255 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetContractStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetContractStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 199, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the listing fee (only callable by contract creator)
        ///</summary>
        /// <param name="new_fee">New fee in microAlgos </param>
        public async Task UpdateListingFee(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 51, 104, 38 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            var result = await base.CallApp(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateListingFee_Transactions(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 51, 104, 38 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2l0YWRlbExpc3RpbmdDb250cmFjdCIsImRlc2MiOiJcbiAgICBDaXRhZGVsIEFJIE1vZGVyYXRvciBMaXN0aW5nIENvbnRyYWN0XG5cbiAgICBUaGlzIGNvbnRyYWN0IGhhbmRsZXMgdGhlIGNyZWF0aW9uIG9mIG5ldyBBSSBtb2RlcmF0b3IgTkZUcy5cbiAgICBBIGNyZWF0b3IgcGF5cyBhIGxpc3RpbmcgZmVlIGFuZCByZWNlaXZlcyBhIHVuaXF1ZSBORlQgbWludGVkIHRvIHRoZWlyIHdhbGxldC5cbiAgICBcbiAgICBLZXkgRmVhdHVyZXM6XG4gICAgLSBObyBoYXJkY29kZWQgYWRkcmVzc2VzIC0gdXNlcyBkeW5hbWljIHRyZWFzdXJ5IGZyb20gZGVwbG95bWVudFxuICAgIC0gTkZUIGdvZXMgZGlyZWN0bHkgdG8gdGhlIHVzZXIncyB3YWxsZXQgKG5vdCBjb250cmFjdCBjcmVhdG9yKVxuICAgIC0gUHJvcGVyIHRyYW5zYWN0aW9uIGdyb3VwIHZhbGlkYXRpb25cbiAgICAtIFRlc3RuZXQgcmVhZHkgZGVwbG95bWVudFxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRDb250cmFjdFN0YXRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6IkRlcGxveXMgdGhlIGNvbnRyYWN0IGFuZCBzZXRzIHRoZSBpbml0aWFsIGNvbmZpZ3VyYXRpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxpc3RpbmdfZmVlIiwiZGVzYyI6IkZlZSBpbiBtaWNyb0FsZ29zIHRvIGxpc3QgYSBtb2RlcmF0b3IgKGUuZy4sIDEwMDAwMCA9IDAuMSBBTEdPKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnkiLCJkZXNjIjoiQWRkcmVzcyB3aGVyZSBmZWVzIHNob3VsZCBiZSBzZW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imxpc3RfbW9kZXJhdG9yIiwiZGVzYyI6IkNyZWF0ZXMgYSBuZXcgQUkgTW9kZXJhdG9yIE5GVCBhbmQgc2VuZHMgaXQgdG8gdGhlIGNhbGxlcidzIHdhbGxldC5cblRoaXMgbXVzdCBiZSBjYWxsZWQgYXMgcGFydCBvZiBhbiBBdG9taWMgVHJhbnNhY3Rpb24gR3JvdXA6IDEuIFBheW1lbnQgdHJhbnNhY3Rpb24gZm9yIHRoZSBsaXN0aW5nIGZlZSAoaW5kZXggMCkgMi4gVGhpcyBhcHAgY2FsbCAoaW5kZXggMSkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdF9uYW1lIiwiZGVzYyI6IlNob3J0IHVuaXQgbmFtZSBmb3IgdGhlIE5GVCAobWF4IDggY2hhcnMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9uYW1lIiwiZGVzYyI6IkZ1bGwgbmFtZSBvZiB0aGUgTkZUIChtYXggMzIgY2hhcnMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF91cmwiLCJkZXNjIjoiVVJMIHBvaW50aW5nIHRvIE5GVCBtZXRhZGF0YSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YWRhdGFfaGFzaCIsImRlc2MiOiJIYXNoIG9mIHRoZSBtZXRhZGF0YSAoMzIgYnl0ZXMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOiJEZXNjcmlwdGlvbiBvZiB0aGUgQUkgbW9kZXJhdG9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBBc3NldCBJRCBvZiB0aGUgbmV3bHkgY3JlYXRlZCBORlQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbGlzdGluZ19mZWUiLCJkZXNjIjoiR2V0IHRoZSBjdXJyZW50IGxpc3RpbmcgZmVlIGluIG1pY3JvQWxnb3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90cmVhc3VyeV9hZGRyZXNzIiwiZGVzYyI6IkdldCB0aGUgY3VycmVudCB0cmVhc3VyeSBhZGRyZXNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29udHJhY3Rfc3RhdHMiLCJkZXNjIjoiR2V0IGNvbnRyYWN0IHN0YXRpc3RpY3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Q29udHJhY3RTdGF0c1JldHVybiIsImRlc2MiOiJUdXBsZSBvZiAodG90YWxfbW9kZXJhdG9ycywgdG90YWxfZmVlc19jb2xsZWN0ZWQpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfbGlzdGluZ19mZWUiLCJkZXNjIjoiVXBkYXRlIHRoZSBsaXN0aW5nIGZlZSAob25seSBjYWxsYWJsZSBieSBjb250cmFjdCBjcmVhdG9yKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfZmVlIiwiZGVzYyI6Ik5ldyBmZWUgaW4gbWljcm9BbGdvcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM3OV0sImVycm9yTWVzc2FnZSI6IkFwcCBjYWxsIG11c3QgYmUgc2Vjb25kIHRyYW5zYWN0aW9uIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0XSwiZXJyb3JNZXNzYWdlIjoiQXNzZXQgVVJMIHRvbyBsb25nIChtYXggOTYgY2hhcnMpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkzXSwiZXJyb3JNZXNzYWdlIjoiQXNzZXQgbmFtZSBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTddLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBuYW1lIHRvbyBsb25nIChtYXggMzIgY2hhcnMpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2XSwiZXJyb3JNZXNzYWdlIjoiRmVlIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjVdLCJlcnJvck1lc3NhZ2UiOiJGZWUgbXVzdCBiZSBzZW50IHRvIHRyZWFzdXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1XSwiZXJyb3JNZXNzYWdlIjoiRmVlIHBheW1lbnQgbXVzdCBjb21lIGZyb20gdGhlIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Ml0sImVycm9yTWVzc2FnZSI6Ik11c3QgYmUgY2FsbGVkIGluIGEgMi10cmFuc2FjdGlvbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MiwxNTgsMTc0LDE5OCwyMTUsMjYyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiB1cGRhdGUgZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBhbW91bnQgbXVzdCBtYXRjaCBsaXN0aW5nIGZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NF0sImVycm9yTWVzc2FnZSI6IlVuaXQgbmFtZSBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODhdLCJlcnJvck1lc3NhZ2UiOiJVbml0IG5hbWUgdG9vIGxvbmcgKG1heCA4IGNoYXJzKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NSwxNjEsMTc3LDIwMSwyMThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyLDQ5Myw1MzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxpc3RpbmdfZmVlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OSw1NTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2ZlZXNfY29sbGVjdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MCw1NDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX21vZGVyYXRvcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDU0MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnlfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YkdsemRGOWhibVJmYldsdWRDNWpiMjUwY21GamRDNURhWFJoWkdWc1RHbHpkR2x1WjBOdmJuUnlZV04wTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURBZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWJHbHpkR2x1WjE5bVpXVWlJREI0TVRVeFpqZGpOelVnSW5SdmRHRnNYMjF2WkdWeVlYUnZjbk1pSUNKMGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDSWdJblJ5WldGemRYSjVYMkZrWkhKbGMzTWlJREI0TURZNE1UQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1kyeGhjM01nUTJsMFlXUmxiRXhwYzNScGJtZERiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEWXhNVEJqTnpjNElEQjRNekJoTUdFMk1EY2dNSGcyWVRNelkyUXdZaUF3ZUdNeU1qTmxZMll3SURCNFpUTmxZbU0zWm1ZZ01IZ3pOVE16TmpneU5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpWOWhjSEJzYVdOaGRHbHZiaWgxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW14cGMzUmZiVzlrWlhKaGRHOXlLR0o1ZEdWYlhTeGllWFJsVzEwc1lubDBaVnRkTEdKNWRHVmJYU3hpZVhSbFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYkdsemRHbHVaMTltWldVb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM1J5WldGemRYSjVYMkZrWkhKbGMzTW9LV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXNhWE4wYVc1blgyWmxaU2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRFVnYldGcGJsOXNhWE4wWDIxdlpHVnlZWFJ2Y2w5eWIzVjBaVUEySUcxaGFXNWZaMlYwWDJ4cGMzUnBibWRmWm1WbFgzSnZkWFJsUURjZ2JXRnBibDluWlhSZmRISmxZWE4xY25sZllXUmtjbVZ6YzE5eWIzVjBaVUE0SUcxaGFXNWZaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpYM0p2ZFhSbFFEa2diV0ZwYmw5MWNHUmhkR1ZmYkdsemRHbHVaMTltWldWZmNtOTFkR1ZBTVRBS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QmpiR0Z6Y3lCRGFYUmhaR1ZzVEdsemRHbHVaME52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVjlzYVhOMGFXNW5YMlpsWlY5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPakUyTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCamJHRnpjeUJEYVhSaFpHVnNUR2x6ZEdsdVowTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVmZiR2x6ZEdsdVoxOW1aV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOWpiMjUwY21GamRGOXpkR0YwY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRISmxZWE4xY25sZllXUmtjbVZ6YzE5eWIzVjBaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZEhKbFlYTjFjbmxmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMnhwYzNScGJtZGZabVZsWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlzYVhOMGFXNW5YMlpsWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzYVhOMFgyMXZaR1Z5WVhSdmNsOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1kyeGhjM01nUTJsMFlXUmxiRXhwYzNScGJtZERiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR3hwYzNSZmJXOWtaWEpoZEc5eUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjloY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCamJHRnpjeUJEYVhSaFpHVnNUR2x6ZEdsdVowTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWZllYQndiR2xqWVhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YkdsemRGOWhibVJmYldsdWRDNWpiMjUwY21GamRDNURhWFJoWkdWc1RHbHpkR2x1WjBOdmJuUnlZV04wTG1OeVpXRjBaVjloY0hCc2FXTmhkR2x2Ymloc2FYTjBhVzVuWDJabFpUb2dkV2x1ZERZMExDQjBjbVZoYzNWeWVUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pReExUUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJQzh2SUdSbFppQmpjbVZoZEdWZllYQndiR2xqWVhScGIyNG9jMlZzWml3Z2JHbHpkR2x1WjE5bVpXVTZJRlZKYm5RMk5Dd2dkSEpsWVhOMWNuazZJRUo1ZEdWektTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuWDJabFpTNTJZV3gxWlNBOUlHeHBjM1JwYm1kZlptVmxDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNhWE4wYVc1blgyWmxaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QnpaV3htTG5SeVpXRnpkWEo1WDJGa1pISmxjM011ZG1Gc2RXVWdQU0IwY21WaGMzVnllUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkSEpsWVhOMWNubGZZV1JrY21WemN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyMXZaR1Z5WVhSdmNuTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDIxdlpHVnlZWFJ2Y25NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJabFpYTmZZMjlzYkdWamRHVmtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxteHBjM1JmWVc1a1gyMXBiblF1WTI5dWRISmhZM1F1UTJsMFlXUmxiRXhwYzNScGJtZERiMjUwY21GamRDNXNhWE4wWDIxdlpHVnlZWFJ2Y2loMWJtbDBYMjVoYldVNklHSjVkR1Z6TENCaGMzTmxkRjl1WVcxbE9pQmllWFJsY3l3Z1lYTnpaWFJmZFhKc09pQmllWFJsY3l3Z2JXVjBZV1JoZEdGZmFHRnphRG9nWW5sMFpYTXNJR1JsYzJOeWFYQjBhVzl1T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwc2FYTjBYMjF2WkdWeVlYUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qVTFMVFl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJzYVhOMFgyMXZaR1Z5WVhSdmNpZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVG9nUW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlRvZ1FubDBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmZFhKc09pQkNlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQnRaWFJoWkdGMFlWOW9ZWE5vT2lCQ2VYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJqb2dRbmwwWlhNS0lDQWdJQzh2SUNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdOU0F4Q2dwc2FYTjBYMjF2WkdWeVlYUnZjbDkzYUdsc1pWOTBiM0JBTkRvS0lDQWdJSEIxYzJocGJuUWdNakF4TUNBdkx5QXlNREV3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCc2FYTjBYMjF2WkdWeVlYUnZjbDloWm5SbGNsOTNhR2xzWlVBNUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd05qZ3hNREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR0lnYkdsemRGOXRiMlJsY21GMGIzSmZkMmhwYkdWZmRHOXdRRFFLQ214cGMzUmZiVzlrWlhKaGRHOXlYMkZtZEdWeVgzZG9hV3hsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG80TkMwNE5nb2dJQ0FnTHk4Z0l5QXRMUzBnVkhKaGJuTmhZM1JwYjI0Z1IzSnZkWEFnVm1Gc2FXUmhkR2x2YmlBdExTMEtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlIZGxJR2hoZG1VZ1pYaGhZM1JzZVNBeUlIUnlZVzV6WVdOMGFXOXVjeUJwYmlCMGFHVWdaM0p2ZFhBS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3VaM0p2ZFhCZmMybDZaU0E5UFNCVlNXNTBOalFvTWlrc0lDSk5kWE4wSUdKbElHTmhiR3hsWkNCcGJpQmhJREl0ZEhKaGJuTmhZM1JwYjI0Z1ozSnZkWEFpQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElHSmxJR05oYkd4bFpDQnBiaUJoSURJdGRISmhibk5oWTNScGIyNGdaM0p2ZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPamc0TFRnNUNpQWdJQ0F2THlBaklGWmxjbWxtZVNCMGFHVWdabVZsSUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0Z0tHMTFjM1FnWW1VZ2RHaGxJR1pwY25OMElIUnlZVzV6WVdOMGFXOXVLUW9nSUNBZ0x5OGdabVZsWDNCaGVXMWxiblFnUFNCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaWd3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCbVpXVmZjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjaXdnSWtabFpTQndZWGx0Wlc1MElHMTFjM1FnWTI5dFpTQm1jbTl0SUhSb1pTQmpZV3hzWlhJaUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JtVmxJSEJoZVcxbGJuUWdiWFZ6ZENCamIyMWxJR1p5YjIwZ2RHaGxJR05oYkd4bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RndE9Ea0tJQ0FnSUM4dklDTWdWbVZ5YVdaNUlIUm9aU0JtWldVZ2NHRjViV1Z1ZENCMGNtRnVjMkZqZEdsdmJpQW9iWFZ6ZENCaVpTQjBhR1VnWm1seWMzUWdkSEpoYm5OaFkzUnBiMjRwQ2lBZ0lDQXZMeUJtWldWZmNHRjViV1Z1ZENBOUlHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1S0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1aV1ZmY0dGNWJXVnVkQzV5WldObGFYWmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxuUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNdWRtRnNkV1VzSUNKR1pXVWdiWFZ6ZENCaVpTQnpaVzUwSUhSdklIUnlaV0Z6ZFhKNUlnb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGNtVmhjM1Z5ZVY5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFWmxaU0J0ZFhOMElHSmxJSE5sYm5RZ2RHOGdkSEpsWVhOMWNua0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pnNExUZzVDaUFnSUNBdkx5QWpJRlpsY21sbWVTQjBhR1VnWm1WbElIQmhlVzFsYm5RZ2RISmhibk5oWTNScGIyNGdLRzExYzNRZ1ltVWdkR2hsSUdacGNuTjBJSFJ5WVc1ellXTjBhVzl1S1FvZ0lDQWdMeThnWm1WbFgzQmhlVzFsYm5RZ1BTQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Ymlnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJoYzNObGNuUWdabVZsWDNCaGVXMWxiblF1WVcxdmRXNTBJRDA5SUhObGJHWXViR2x6ZEdsdVoxOW1aV1V1ZG1Gc2RXVXNJQ0pRWVhsdFpXNTBJR0Z0YjNWdWRDQnRkWE4wSUcxaGRHTm9JR3hwYzNScGJtY2dabVZsSWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliR2x6ZEdsdVoxOW1aV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjE5bVpXVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdZVzF2ZFc1MElHMTFjM1FnYldGMFkyZ2diR2x6ZEdsdVp5Qm1aV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qazBMVGsxQ2lBZ0lDQXZMeUFqSUZabGNtbG1lU0IwYUdseklHbHpJSFJvWlNCelpXTnZibVFnZEhKaGJuTmhZM1JwYjI0Z2FXNGdkR2hsSUdkeWIzVndDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbWR5YjNWd1gybHVaR1Y0SUQwOUlGVkpiblEyTkNneEtTd2dJa0Z3Y0NCallXeHNJRzExYzNRZ1ltVWdjMlZqYjI1a0lIUnlZVzV6WVdOMGFXOXVJR2x1SUdkeWIzVndJZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGd2NDQmpZV3hzSUcxMWMzUWdZbVVnYzJWamIyNWtJSFJ5WVc1ellXTjBhVzl1SUdsdUlHZHliM1Z3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzVOeTA1T0FvZ0lDQWdMeThnSXlBdExTMGdTVzV3ZFhRZ1ZtRnNhV1JoZEdsdmJpQXRMUzBLSUNBZ0lDOHZJR0Z6YzJWeWRDQjFibWwwWDI1aGJXVXViR1Z1WjNSb0lENDlJRlZKYm5RMk5DZ3hLU3dnSWxWdWFYUWdibUZ0WlNCallXNXViM1FnWW1VZ1pXMXdkSGtpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBkQ0J1WVcxbElHTmhibTV2ZENCaVpTQmxiWEIwZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZPVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQjFibWwwWDI1aGJXVXViR1Z1WjNSb0lEdzlJRlZKYm5RMk5DZzRLU3dnSWxWdWFYUWdibUZ0WlNCMGIyOGdiRzl1WnlBb2JXRjRJRGdnWTJoaGNuTXBJZ29nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBkQ0J1WVcxbElIUnZieUJzYjI1bklDaHRZWGdnT0NCamFHRnljeWtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDI1aGJXVXViR1Z1WjNSb0lENDlJRlZKYm5RMk5DZ3hLU3dnSWtGemMyVjBJRzVoYldVZ1kyRnVibTkwSUdKbElHVnRjSFI1SWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFRnpjMlYwSUc1aGJXVWdZMkZ1Ym05MElHSmxJR1Z0Y0hSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRGOXVZVzFsTG14bGJtZDBhQ0E4UFNCVlNXNTBOalFvTXpJcExDQWlRWE56WlhRZ2JtRnRaU0IwYjI4Z2JHOXVaeUFvYldGNElETXlJR05vWVhKektTSUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FYTnpaWFFnYm1GdFpTQjBiMjhnYkc5dVp5QW9iV0Y0SURNeUlHTm9ZWEp6S1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWE56WlhSZmRYSnNMbXhsYm1kMGFDQThQU0JWU1c1ME5qUW9PVFlwTENBaVFYTnpaWFFnVlZKTUlIUnZieUJzYjI1bklDaHRZWGdnT1RZZ1kyaGhjbk1wSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09UWWdMeThnT1RZS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWE56WlhRZ1ZWSk1JSFJ2YnlCc2IyNW5JQ2h0WVhnZ09UWWdZMmhoY25NcENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG94TURRdE1URTVDaUFnSUNBdkx5QWpJQzB0TFNCT1JsUWdRM0psWVhScGIyNGdMUzB0Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0IwYUdVZ1RrWlVJSGRwZEdnZ2RHaGxJR05oYkd4bGNpQmhjeUIwYUdVZ2NtVmphWEJwWlc1MElHRnVaQ0J0WVc1aFoyVnlDaUFnSUNBdkx5QnVablJmWVhOelpYUmZhV1FnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRFc0lDQWpJRTVHVkNBdElIUnZkR0ZzSUhOMWNIQnNlU0J2WmlBeENpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCa1pXWmhkV3gwWDJaeWIzcGxiajFHWVd4elpTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5ZFc1cGRGOXVZVzFsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlZWE56WlhSZmJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlZWE56WlhSZmRYSnNMQW9nSUNBZ0x5OGdJQ0FnSUcxbGRHRmtZWFJoWDJoaGMyZzliV1YwWVdSaGRHRmZhR0Z6YUN3S0lDQWdJQzh2SUNBZ0lDQWpJRWxOVUU5U1ZFRk9WRG9nVkdobElHTmhiR3hsY2lCblpYUnpJR1oxYkd3Z1kyOXVkSEp2YkN3Z2JtOTBJSFJvWlNCamIyNTBjbUZqZENCamNtVmhkRzl5Q2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVU5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUzVqY21WaGRHVmtYMkZ6YzJWMExtbGtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG94TVRRdE1URTFDaUFnSUNBdkx5QWpJRWxOVUU5U1ZFRk9WRG9nVkdobElHTmhiR3hsY2lCblpYUnpJR1oxYkd3Z1kyOXVkSEp2YkN3Z2JtOTBJSFJvWlNCamIyNTBjbUZqZENCamNtVmhkRzl5Q2lBZ0lDQXZMeUJ0WVc1aFoyVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE1UWXRNVEU0Q2lBZ0lDQXZMeUJ5WlhObGNuWmxQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUJtY21WbGVtVTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJR05zWVhkaVlXTnJQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTlpYUmhaR0YwWVVoaGMyZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVlNUQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPakV3T0FvZ0lDQWdMeThnWkdWamFXMWhiSE05TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdkRzkwWVd3OU1Td2dJQ01nVGtaVUlDMGdkRzkwWVd3Z2MzVndjR3g1SUc5bUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdOQzB4TURZS0lDQWdJQzh2SUNNZ0xTMHRJRTVHVkNCRGNtVmhkR2x2YmlBdExTMEtJQ0FnSUM4dklDTWdRM0psWVhSbElIUm9aU0JPUmxRZ2QybDBhQ0IwYUdVZ1kyRnNiR1Z5SUdGeklIUm9aU0J5WldOcGNHbGxiblFnWVc1a0lHMWhibUZuWlhJS0lDQWdJQzh2SUc1bWRGOWhjM05sZEY5cFpDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE1EUXRNVEU1Q2lBZ0lDQXZMeUFqSUMwdExTQk9SbFFnUTNKbFlYUnBiMjRnTFMwdENpQWdJQ0F2THlBaklFTnlaV0YwWlNCMGFHVWdUa1pVSUhkcGRHZ2dkR2hsSUdOaGJHeGxjaUJoY3lCMGFHVWdjbVZqYVhCcFpXNTBJR0Z1WkNCdFlXNWhaMlZ5Q2lBZ0lDQXZMeUJ1Wm5SZllYTnpaWFJmYVdRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BURXNJQ0FqSUU1R1ZDQXRJSFJ2ZEdGc0lITjFjSEJzZVNCdlppQXhDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyWnliM3BsYmoxR1lXeHpaU3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBYMjVoYldVOWRXNXBkRjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5WVhOelpYUmZibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQjFjbXc5WVhOelpYUmZkWEpzTEFvZ0lDQWdMeThnSUNBZ0lHMWxkR0ZrWVhSaFgyaGhjMmc5YldWMFlXUmhkR0ZmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0FqSUVsTlVFOVNWRUZPVkRvZ1ZHaGxJR05oYkd4bGNpQm5aWFJ6SUdaMWJHd2dZMjl1ZEhKdmJDd2dibTkwSUhSb1pTQmpiMjUwY21GamRDQmpjbVZoZEc5eUNpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1VOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1M1amNtVmhkR1ZrWDJGemMyVjBMbWxrQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJeExURXlPQW9nSUNBZ0x5OGdJeUF0TFMwZ1UyVnVaQ0JPUmxRZ2RHOGdWWE5sY2lkeklGZGhiR3hsZENBdExTMEtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdkR2hsSUc1bGQyeDVJR055WldGMFpXUWdUa1pVSUhSdklIUm9aU0JqWVd4c1pYSW5jeUIzWVd4c1pYUUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM05sYm1SbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5Ym1aMFgyRnpjMlYwWDJsa0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCaGMzTmxkRjl6Wlc1a1pYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUb3hNakV0TVRJekNpQWdJQ0F2THlBaklDMHRMU0JUWlc1a0lFNUdWQ0IwYnlCVmMyVnlKM01nVjJGc2JHVjBJQzB0TFFvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCMGFHVWdibVYzYkhrZ1kzSmxZWFJsWkNCT1JsUWdkRzhnZEdobElHTmhiR3hsY2lkeklIZGhiR3hsZEFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPakV5TVMweE1qZ0tJQ0FnSUM4dklDTWdMUzB0SUZObGJtUWdUa1pVSUhSdklGVnpaWEluY3lCWFlXeHNaWFFnTFMwdENpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlIUm9aU0J1Wlhkc2VTQmpjbVZoZEdWa0lFNUdWQ0IwYnlCMGFHVWdZMkZzYkdWeUozTWdkMkZzYkdWMENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVzVtZEY5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUb3hNekF0TVRNeENpQWdJQ0F2THlBaklDMHRMU0JWY0dSaGRHVWdRMjl1ZEhKaFkzUWdVM1JoZEdsemRHbGpjeUF0TFMwS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmJXOWtaWEpoZEc5eWN5NTJZV3gxWlNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl0YjJSbGNtRjBiM0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxdlpHVnlZWFJ2Y25NZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYlc5a1pYSmhkRzl5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG94TXpJS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1F1ZG1Gc2RXVWdLejBnYzJWc1ppNXNhWE4wYVc1blgyWmxaUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlpsWlhOZlkyOXNiR1ZqZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyWmxaWE5mWTI5c2JHVmpkR1ZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHBjM1JwYm1kZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUnBibWRmWm1WbElHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVE0wTFRFek5nb2dJQ0FnTHk4Z0l5QXRMUzBnVEc5bloybHVaeUJtYjNJZ1JuSnZiblJsYm1RZ1NXNTBaV2R5WVhScGIyNGdMUzB0Q2lBZ0lDQXZMeUFqSUV4dlp5QjBhR1VnVGtaVUlHTnlaV0YwYVc5dUlHWnZjaUJsWVhONUlIUnlZV05yYVc1bkNpQWdJQ0F2THlCc2IyY29JbTVtZEY5amNtVmhkR1ZrSWl3Z2JtWjBYMkZ6YzJWMFgybGtMQ0JVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjl1WVcxbExDQnpaWEE5SWpvaUtRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW01bWRGOWpjbVZoZEdWa09pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSTZJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVowWDJGemMyVjBYMmxrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViR2x6ZEY5aGJtUmZiV2x1ZEM1amIyNTBjbUZqZEM1RGFYUmhaR1ZzVEdsemRHbHVaME52Ym5SeVlXTjBMbWRsZEY5c2FYTjBhVzVuWDJabFpTZ3BJQzArSUhWcGJuUTJORG9LWjJWMFgyeHBjM1JwYm1kZlptVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVzYVhOMGFXNW5YMlpsWlM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHBjM1JwYm1kZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUnBibWRmWm1WbElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXhwYzNSZllXNWtYMjFwYm5RdVkyOXVkSEpoWTNRdVEybDBZV1JsYkV4cGMzUnBibWREYjI1MGNtRmpkQzVuWlhSZmRISmxZWE4xY25sZllXUmtjbVZ6Y3lncElDMCtJR0o1ZEdWek9ncG5aWFJmZEhKbFlYTjFjbmxmWVdSa2NtVnpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZEhKbFlYTjFjbmxmWVdSa2NtVnpjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SeVpXRnpkWEo1WDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRISmxZWE4xY25sZllXUmtjbVZ6Y3lCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhWE4wWDJGdVpGOXRhVzUwTG1OdmJuUnlZV04wTGtOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUXVaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOWpiMjUwY21GamRGOXpkR0YwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZiVzlrWlhKaGRHOXljeTUyWVd4MVpTa3NJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1F1ZG1Gc2RXVXBLU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5dGIyUmxjbUYwYjNKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMXZaR1Z5WVhSdmNuTWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZabVZsYzE5amIyeHNaV04wWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1FnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhWE4wWDJGdVpGOXRhVzUwTG1OdmJuUnlZV04wTGtOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUXVkWEJrWVhSbFgyeHBjM1JwYm1kZlptVmxLRzVsZDE5bVpXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyeHBjM1JwYm1kZlptVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk1UWXdMVEUyTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnZFhCa1lYUmxYMnhwYzNScGJtZGZabVZsS0hObGJHWXNJRzVsZDE5bVpXVTZJRlZKYm5RMk5Da2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNVFk0TFRFMk9Rb2dJQ0FnTHk4Z0l5QlBibXg1SUhSb1pTQmpiMjUwY21GamRDQmpjbVZoZEc5eUlHTmhiaUIxY0dSaGRHVWdkR2hsSUdabFpRb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2RYQmtZWFJsSUdabFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlIVndaR0YwWlNCbVpXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFM01Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc1bGQxOW1aV1VnUGlCVlNXNTBOalFvTUNrc0lDSkdaV1VnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhOelpYSjBJQzh2SUVabFpTQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUb3hOeklLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjE5bVpXVXVkbUZzZFdVZ1BTQnVaWGRmWm1WbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2FYTjBhVzVuWDJabFpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFM05DMHhOelVLSUNBZ0lDOHZJQ01nVEc5bklIUm9aU0JtWldVZ2RYQmtZWFJsQ2lBZ0lDQXZMeUJzYjJjb0ltWmxaVjkxY0dSaGRHVmtJaXdnYm1WM1gyWmxaU3dnYzJWd1BTSTZJaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklDSm1aV1ZmZFhCa1lYUmxaRG9pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1CZ3RzYVhOMGFXNW5YMlpsWlFRVkgzeDFFSFJ2ZEdGc1gyMXZaR1Z5WVhSdmNuTVVkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1FRZEhKbFlYTjFjbmxmWVdSa2NtVnpjd01HZ1FFeEcwRUFNWUlHQkdFUXgzZ0VNS0NtQndScU04MExCTUlqN1BBRTQrdkgvd1ExTTJnbU5ob0FqZ1lBZWdCTEFEb0FJZ0FTQUFJaVF6RVpGRVF4R0VRMkdnRVhpQUdTSTBNeEdSUkVNUmhFaUFGNktVeFFzQ05ETVJrVVJERVlSSWdCWkVrVkZsY0dBa3hRS1V4UXNDTkRNUmtVUkRFWVJJZ0JSeFlwVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBTmhvRlZ3SUFpQUF4RmlsTVVMQWpRekVaRkVReEdCUkVOaG9CRnpZYUFsY0NBSWdBQWlORGlnSUFLSXYrWnljRWkvOW5LaUpuS3lKbmlZb0ZBWUhhRHpJTURVRUFHTEdCQnJJUWdRV3lHU2NGc2g0bkJiSWZJcklCczBMLzN6SUVnUUlTUkNJNEVDTVNSQ0k0QURFQUVrUWlPQWNpSndSbFJCSkVJamdJSWlobFJCSkVNUllqRWtTTCt4VkpSSUVJRGtTTC9CVkpSSUVnRGtTTC9SV0JZQTVFc1RFQVJ3T3lMTElyc2lxeUtZditzaWlML2JJbmkveXlKb3Y3c2lVaXNpUWlzaU1qc2lLQkE3SVFJcklCczdROHNURUFNZ3BMQXJJUkk3SVNzaE95RklFRXNoQWlzZ0d6SWlwbFJDTUlLa3huSWl0bFJDSW9aVVFJSzB4blNSYUFERzVtZEY5amNtVmhkR1ZrT2t4UWdBRTZVREVBVUlBQk9sQ0wvRkN3aVNJb1pVU0pJaWNFWlVTSklpcGxSQllpSzJWRUZsQ0ppZ0VBTVFBeUNSSkVpLzlFS0l2L1o0di9Gb0FNWm1WbFgzVndaR0YwWldRNlRGQ3dpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
