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

namespace Arc56.Generated.DarshanKrishna_DK.CitadelAlgo.CitadelListingContract_74624511
{


    //
    // 
    //    Citadel AI Moderator Listing Contract
    //
    //    This contract handles the creation of new Master AI moderators.
    //    A creator pays a flat fee to list their moderator, and in return,
    //    a unique Master AI NFT is minted to their wallet, proving ownership.
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
        }

        ///<summary>
        ///Deploys the contract and sets the initial listing fee and treasury address.
        ///</summary>
        /// <param name="listing_fee"> </param>
        /// <param name="treasury"> </param>
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
        ///Mints a new "Master AI" NFT to prove ownership.
        ///This must be called as part of an Atomic Transaction Group: 1. Payment transaction for the listing fee (index 0) 2. This app call (index 1)
        ///</summary>
        /// <param name="unit_name"> </param>
        /// <param name="asset_name"> </param>
        /// <param name="asset_url"> </param>
        public async Task<ulong> ListModerator(byte[] unit_name, byte[] asset_name, byte[] asset_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 9, 196, 147 };
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); unit_nameAbi.From(unit_name);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_nameAbi.From(asset_name);
            var asset_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_urlAbi.From(asset_url);

            var result = await base.CallApp(new List<object> { abiHandle, unit_nameAbi, asset_nameAbi, asset_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListModerator_Transactions(byte[] unit_name, byte[] asset_name, byte[] asset_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 9, 196, 147 };
            var unit_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); unit_nameAbi.From(unit_name);
            var asset_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_nameAbi.From(asset_name);
            var asset_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); asset_urlAbi.From(asset_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, unit_nameAbi, asset_nameAbi, asset_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current listing fee
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2l0YWRlbExpc3RpbmdDb250cmFjdCIsImRlc2MiOiJcbiAgICBDaXRhZGVsIEFJIE1vZGVyYXRvciBMaXN0aW5nIENvbnRyYWN0XG5cbiAgICBUaGlzIGNvbnRyYWN0IGhhbmRsZXMgdGhlIGNyZWF0aW9uIG9mIG5ldyBNYXN0ZXIgQUkgbW9kZXJhdG9ycy5cbiAgICBBIGNyZWF0b3IgcGF5cyBhIGZsYXQgZmVlIHRvIGxpc3QgdGhlaXIgbW9kZXJhdG9yLCBhbmQgaW4gcmV0dXJuLFxuICAgIGEgdW5pcXVlIE1hc3RlciBBSSBORlQgaXMgbWludGVkIHRvIHRoZWlyIHdhbGxldCwgcHJvdmluZyBvd25lcnNoaXAuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOiJEZXBsb3lzIHRoZSBjb250cmFjdCBhbmQgc2V0cyB0aGUgaW5pdGlhbCBsaXN0aW5nIGZlZSBhbmQgdHJlYXN1cnkgYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ19mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyZWFzdXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imxpc3RfbW9kZXJhdG9yIiwiZGVzYyI6Ik1pbnRzIGEgbmV3IFwiTWFzdGVyIEFJXCIgTkZUIHRvIHByb3ZlIG93bmVyc2hpcC5cblRoaXMgbXVzdCBiZSBjYWxsZWQgYXMgcGFydCBvZiBhbiBBdG9taWMgVHJhbnNhY3Rpb24gR3JvdXA6IDEuIFBheW1lbnQgdHJhbnNhY3Rpb24gZm9yIHRoZSBsaXN0aW5nIGZlZSAoaW5kZXggMCkgMi4gVGhpcyBhcHAgY2FsbCAoaW5kZXggMSkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF91cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIEFzc2V0IElEIG9mIHRoZSBuZXdseSBjcmVhdGVkIE1hc3RlciBBSSBORlQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2xpc3RpbmdfZmVlIiwiZGVzYyI6IkdldCB0aGUgY3VycmVudCBsaXN0aW5nIGZlZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RyZWFzdXJ5X2FkZHJlc3MiLCJkZXNjIjoiR2V0IHRoZSBjdXJyZW50IHRyZWFzdXJ5IGFkZHJlc3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjE4XSwiZXJyb3JNZXNzYWdlIjoiRmVlIG11c3QgYmUgc2VudCB0byB0aGUgdHJlYXN1cnkgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6IkZlZSBwYXltZW50IG11c3QgY29tZSBmcm9tIHRoZSBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NiwxMTAsMTI3LDE2Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyN10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgYW1vdW50IG11c3QgbWF0Y2ggdGhlIGxpc3RpbmcgZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODksMTEzLDEzMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjUsMjc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5saXN0aW5nX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTYsMjgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50cmVhc3VyeV9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViR2x6ZEY5aGJtUmZiV2x1ZEM1amIyNTBjbUZqZEM1RGFYUmhaR1ZzVEdsemRHbHVaME52Ym5SeVlXTjBMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKc2FYTjBhVzVuWDJabFpTSWdJblJ5WldGemRYSjVYMkZrWkhKbGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTJsMFlXUmxiRXhwYzNScGJtZERiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5qRXhNR00zTnpnZ01IaGhaREE1WXpRNU15QXdlRFpoTXpOalpEQmlJREI0WXpJeU0yVmpaakFnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0b2RXbHVkRFkwTEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnNhWE4wWDIxdlpHVnlZWFJ2Y2loaWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjlzYVhOMGFXNW5YMlpsWlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZkSEpsWVhOMWNubGZZV1JrY21WemN5Z3BZbmwwWlZ0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTlNCdFlXbHVYMnhwYzNSZmJXOWtaWEpoZEc5eVgzSnZkWFJsUURZZ2JXRnBibDluWlhSZmJHbHpkR2x1WjE5bVpXVmZjbTkxZEdWQU55QnRZV2x1WDJkbGRGOTBjbVZoYzNWeWVWOWhaR1J5WlhOelgzSnZkWFJsUURnS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk1UVUtJQ0FnSUM4dklHTnNZWE56SUVOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzUnlaV0Z6ZFhKNVgyRmtaSEpsYzNOZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZEhKbFlYTjFjbmxmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMnhwYzNScGJtZGZabVZsWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMnhwYzNScGJtZGZabVZsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMnhwYzNSZmJXOWtaWEpoZEc5eVgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMUNpQWdJQ0F2THlCamJHRnpjeUJEYVhSaFpHVnNUR2x6ZEdsdVowTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUd4cGMzUmZiVzlrWlhKaGRHOXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJsOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGFYUmhaR1ZzVEdsemRHbHVaME52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNSZllXNWtYMjFwYm5RdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJHbHpkRjloYm1SZmJXbHVkQzVqYjI1MGNtRmpkQzVEYVhSaFpHVnNUR2x6ZEdsdVowTnZiblJ5WVdOMExtTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJpaHNhWE4wYVc1blgyWmxaVG9nZFdsdWREWTBMQ0IwY21WaGMzVnllVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbU55WldGMFpWOWhjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qTXdMVE14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvYzJWc1ppd2diR2x6ZEdsdVoxOW1aV1U2SUZWSmJuUTJOQ3dnZEhKbFlYTjFjbms2SUVKNWRHVnpLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1blgyWmxaUzUyWVd4MVpTQTlJR3hwYzNScGJtZGZabVZsQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pzYVhOMGFXNW5YMlpsWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ6Wld4bUxuUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNdWRtRnNkV1VnUFNCMGNtVmhjM1Z5ZVFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhWE4wWDJGdVpGOXRhVzUwTG1OdmJuUnlZV04wTGtOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUXViR2x6ZEY5dGIyUmxjbUYwYjNJb2RXNXBkRjl1WVcxbE9pQmllWFJsY3l3Z1lYTnpaWFJmYm1GdFpUb2dZbmwwWlhNc0lHRnpjMlYwWDNWeWJEb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tiR2x6ZEY5dGIyUmxjbUYwYjNJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG96T0MwME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2JHbHpkRjl0YjJSbGNtRjBiM0lvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBYMjVoYldVNklFSjVkR1Z6TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTZJRUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzVnliRG9nUW5sMFpYTUtJQ0FnSUM4dklDa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRGOWhibVJmYldsdWRDOWpiMjUwY21GamRDNXdlVG8xTlMwMU53b2dJQ0FnTHk4Z0l5QXRMUzBnVm1WeWFXWnBZMkYwYVc5dUlDMHRMUW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dkR2hsSUdabFpTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVJQ2h0ZFhOMElHSmxJSFJvWlNCbWFYSnpkQ0IwY21GdWMyRmpkR2x2YmlrS0lDQWdJQzh2SUdabFpWOXdZWGx0Wlc1MElEMGdaM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0b01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdabVZsWDNCaGVXMWxiblF1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSkdaV1VnY0dGNWJXVnVkQ0J0ZFhOMElHTnZiV1VnWm5KdmJTQjBhR1VnWTJGc2JHVnlJZ29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVpsWlNCd1lYbHRaVzUwSUcxMWMzUWdZMjl0WlNCbWNtOXRJSFJvWlNCallXeHNaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qVTFMVFUzQ2lBZ0lDQXZMeUFqSUMwdExTQldaWEpwWm1sallYUnBiMjRnTFMwdENpQWdJQ0F2THlBaklGWmxjbWxtZVNCMGFHVWdabVZsSUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0Z0tHMTFjM1FnWW1VZ2RHaGxJR1pwY25OMElIUnlZVzV6WVdOMGFXOXVLUW9nSUNBZ0x5OGdabVZsWDNCaGVXMWxiblFnUFNCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaWd3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wWDJGdVpGOXRhVzUwTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmhjM05sY25RZ1ptVmxYM0JoZVcxbGJuUXVjbVZqWldsMlpYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1MGNtVmhjM1Z5ZVY5aFpHUnlaWE56TG5aaGJIVmxMQ0FpUm1WbElHMTFjM1FnWW1VZ2MyVnVkQ0IwYnlCMGFHVWdkSEpsWVhOMWNua2dZV1JrY21WemN5SUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRISmxZWE4xY25sZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBjbVZoYzNWeWVWOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdaV1VnYlhWemRDQmlaU0J6Wlc1MElIUnZJSFJvWlNCMGNtVmhjM1Z5ZVNCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzFOUzAxTndvZ0lDQWdMeThnSXlBdExTMGdWbVZ5YVdacFkyRjBhVzl1SUMwdExRb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ2RHaGxJR1psWlNCd1lYbHRaVzUwSUhSeVlXNXpZV04wYVc5dUlDaHRkWE4wSUdKbElIUm9aU0JtYVhKemRDQjBjbUZ1YzJGamRHbHZiaWtLSUNBZ0lDOHZJR1psWlY5d1lYbHRaVzUwSUQwZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdZWE56WlhKMElHWmxaVjl3WVhsdFpXNTBMbUZ0YjNWdWRDQTlQU0J6Wld4bUxteHBjM1JwYm1kZlptVmxMblpoYkhWbExDQWlVR0Y1YldWdWRDQmhiVzkxYm5RZ2JYVnpkQ0J0WVhSamFDQjBhR1VnYkdsemRHbHVaeUJtWldVaUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pzYVhOMGFXNW5YMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNhWE4wYVc1blgyWmxaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0JoYlc5MWJuUWdiWFZ6ZENCdFlYUmphQ0IwYUdVZ2JHbHpkR2x1WnlCbVpXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBYMkZ1WkY5dGFXNTBMMk52Ym5SeVlXTjBMbkI1T2pZeUxUYzNDaUFnSUNBdkx5QWpJQzB0TFNCQmMzTmxkQ0JEY21WaGRHbHZiaUFvVFdsdWRHbHVaeUIwYUdVZ1RrWlVLU0F0TFMwS0lDQWdJQzh2SUNNZ1ZHaGxJR052Ym5SeVlXTjBJRzVsWldSeklIUnZJSEJoZVNCMGFHVWdUVUpTSUdadmNpQjBhR2x6SUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1TGdvZ0lDQWdMeThnSXlCRmJuTjFjbVVnZEdobElHTnZiblJ5WVdOMElHaGhjeUJpWldWdUlHWjFibVJsWkNCM2FYUm9JR0YwSUd4bFlYTjBJREF1TVNCQlRFZFBMZ29nSUNBZ0x5OGdiV0Z6ZEdWeVgyRnBYMkZ6YzJWMFgybGtJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TENBZ0l5QlViM1JoYkNCemRYQndiSGtnYjJZZ01TQnRZV3RsY3lCcGRDQmhJSFZ1YVhGMVpTQk9SbFFLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMTFibWwwWDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxaGMzTmxkRjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxaGMzTmxkRjkxY213c0NpQWdJQ0F2THlBZ0lDQWdJeUJVYUdVZ1kzSmxZWFJ2Y2lCblpYUnpJR1oxYkd3Z1lXNWtJSEJsY20xaGJtVnVkQ0JqYjI1MGNtOXNJRzkyWlhJZ2RHaGxhWElnVFdGemRHVnlJRUZKSUU1R1ZBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk56SXROek1LSUNBZ0lDOHZJQ01nVkdobElHTnlaV0YwYjNJZ1oyVjBjeUJtZFd4c0lHRnVaQ0J3WlhKdFlXNWxiblFnWTI5dWRISnZiQ0J2ZG1WeUlIUm9aV2x5SUUxaGMzUmxjaUJCU1NCT1JsUUtJQ0FnSUM4dklHMWhibUZuWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPamMwTFRjMkNpQWdJQ0F2THlCeVpYTmxjblpsUFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlCbWNtVmxlbVU5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUdOc1lYZGlZV05yUFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkRiR0YzWW1GamF3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFWnlaV1Y2WlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJOWVc1aFoyVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZVa3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEY5aGJtUmZiV2x1ZEM5amIyNTBjbUZqZEM1d2VUbzJPQW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMFgyRnVaRjl0YVc1MEwyTnZiblJ5WVdOMExuQjVPalkzQ2lBZ0lDQXZMeUJrWldOcGJXRnNjejB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklIUnZkR0ZzUFRFc0lDQWpJRlJ2ZEdGc0lITjFjSEJzZVNCdlppQXhJRzFoYTJWeklHbDBJR0VnZFc1cGNYVmxJRTVHVkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJVYjNSaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUmZZVzVrWDIxcGJuUXZZMjl1ZEhKaFkzUXVjSGs2TmpJdE5qVUtJQ0FnSUM4dklDTWdMUzB0SUVGemMyVjBJRU55WldGMGFXOXVJQ2hOYVc1MGFXNW5JSFJvWlNCT1JsUXBJQzB0TFFvZ0lDQWdMeThnSXlCVWFHVWdZMjl1ZEhKaFkzUWdibVZsWkhNZ2RHOGdjR0Y1SUhSb1pTQk5RbElnWm05eUlIUm9hWE1nYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjR1Q2lBZ0lDQXZMeUFqSUVWdWMzVnlaU0IwYUdVZ1kyOXVkSEpoWTNRZ2FHRnpJR0psWlc0Z1puVnVaR1ZrSUhkcGRHZ2dZWFFnYkdWaGMzUWdNQzR4SUVGTVIwOHVDaUFnSUNBdkx5QnRZWE4wWlhKZllXbGZZWE56WlhSZmFXUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk5qSXROemNLSUNBZ0lDOHZJQ01nTFMwdElFRnpjMlYwSUVOeVpXRjBhVzl1SUNoTmFXNTBhVzVuSUhSb1pTQk9SbFFwSUMwdExRb2dJQ0FnTHk4Z0l5QlVhR1VnWTI5dWRISmhZM1FnYm1WbFpITWdkRzhnY0dGNUlIUm9aU0JOUWxJZ1ptOXlJSFJvYVhNZ2FXNXVaWElnZEhKaGJuTmhZM1JwYjI0dUNpQWdJQ0F2THlBaklFVnVjM1Z5WlNCMGFHVWdZMjl1ZEhKaFkzUWdhR0Z6SUdKbFpXNGdablZ1WkdWa0lIZHBkR2dnWVhRZ2JHVmhjM1FnTUM0eElFRk1SMDh1Q2lBZ0lDQXZMeUJ0WVhOMFpYSmZZV2xmWVhOelpYUmZhV1FnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRFc0lDQWpJRlJ2ZEdGc0lITjFjSEJzZVNCdlppQXhJRzFoYTJWeklHbDBJR0VnZFc1cGNYVmxJRTVHVkFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnWkdWbVlYVnNkRjltY205NlpXNDlSbUZzYzJVc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQWFZ1YVhSZmJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBXRnpjMlYwWDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFhKc1BXRnpjMlYwWDNWeWJDd0tJQ0FnSUM4dklDQWdJQ0FqSUZSb1pTQmpjbVZoZEc5eUlHZGxkSE1nWm5Wc2JDQmhibVFnY0dWeWJXRnVaVzUwSUdOdmJuUnliMndnYjNabGNpQjBhR1ZwY2lCTllYTjBaWElnUVVrZ1RrWlVDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXoxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tTNWpjbVZoZEdWa1gyRnpjMlYwTG1sa0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JmWVc1a1gyMXBiblF2WTI5dWRISmhZM1F1Y0hrNk56a3RPREFLSUNBZ0lDOHZJQ01nVW1WMGRYSnVJSFJvWlNCSlJDQnZaaUIwYUdVZ2JtVjNiSGtnWTNKbFlYUmxaQ0JCVTBFS0lDQWdJQzh2SUhKbGRIVnliaUJ0WVhOMFpYSmZZV2xmWVhOelpYUmZhV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhWE4wWDJGdVpGOXRhVzUwTG1OdmJuUnlZV04wTGtOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUXVaMlYwWDJ4cGMzUnBibWRmWm1WbEtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSZmJHbHpkR2x1WjE5bVpXVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXViR2x6ZEdsdVoxOW1aV1V1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc2FYTjBhVzVuWDJabFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYVhOMGFXNW5YMlpsWlNCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhWE4wWDJGdVpGOXRhVzUwTG1OdmJuUnlZV04wTGtOcGRHRmtaV3hNYVhOMGFXNW5RMjl1ZEhKaFkzUXVaMlYwWDNSeVpXRnpkWEo1WDJGa1pISmxjM01vS1NBdFBpQmllWFJsY3pvS1oyVjBYM1J5WldGemRYSjVYMkZrWkhKbGMzTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkRjloYm1SZmJXbHVkQzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkSEpsWVhOMWNubGZZV1JrY21WemN5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ5WldGemRYSjVYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQXdRVkgzeDFDMnhwYzNScGJtZGZabVZsRUhSeVpXRnpkWEo1WDJGa1pISmxjM014RzBFQUk0SUVCR0VReDNnRXJRbkVrd1JxTTgwTEJNSWo3UEEyR2dDT0JBQk9BQ3NBR2dBQ0lrTXhHUlJFTVJoRWlBQzVTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFDY0ZpaE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0NJQUNvV0tFeFFzQ05ETVJrVVJERVlGRVEyR2dFWE5ob0NWd0lBaUFBQ0kwT0tBZ0FwaS81bktvdi9aNG1LQXdFaU9CQWpFa1FpT0FBeEFCSkVJamdISWlwbFJCSkVJamdJSWlsbFJCSkVzVEVBUndPeUxMSXJzaXF5S1l2L3NpZUwvckltaS8yeUpTS3lKQ0t5SXlPeUlvRURzaEFpc2dHenREeUpJaWxsUklraUttVkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
