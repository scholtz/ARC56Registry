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

namespace Arc56.Generated.chainaim3003.algoTITANV5.NegotiableFinBLV1_abd0f652
{


    public class NegotiableFinBLV1Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NegotiableFinBLV1Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Test method like HelloWorld
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create Financial BL (simplified)
        ///</summary>
        /// <param name="description"> </param>
        /// <param name="cargoValue"> </param>
        /// <param name="blType"> </param>
        /// <param name="creditRating"> </param>
        /// <param name="riskScore"> </param>
        /// <param name="yieldRate"> </param>
        /// <param name="vleiID"> </param>
        /// <param name="jurisdictionCode"> </param>
        /// <param name="complianceHash"> </param>
        /// <param name="incoterms"> </param>
        /// <param name="insurancePolicyID"> </param>
        /// <param name="lcrReference"> </param>
        public async Task<string> CreateFinancialBl(string description, ulong cargoValue, ulong blType, ulong creditRating, ulong riskScore, ulong yieldRate, string vleiID, string jurisdictionCode, string complianceHash, string incoterms, string insurancePolicyID, string lcrReference, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 1, 253, 35 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var cargoValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cargoValueAbi.From(cargoValue);
            var blTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blTypeAbi.From(blType);
            var creditRatingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creditRatingAbi.From(creditRating);
            var riskScoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskScoreAbi.From(riskScore);
            var yieldRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yieldRateAbi.From(yieldRate);
            var vleiIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vleiIDAbi.From(vleiID);
            var jurisdictionCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); jurisdictionCodeAbi.From(jurisdictionCode);
            var complianceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); complianceHashAbi.From(complianceHash);
            var incotermsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); incotermsAbi.From(incoterms);
            var insurancePolicyIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); insurancePolicyIDAbi.From(insurancePolicyID);
            var lcrReferenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); lcrReferenceAbi.From(lcrReference);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi, cargoValueAbi, blTypeAbi, creditRatingAbi, riskScoreAbi, yieldRateAbi, vleiIDAbi, jurisdictionCodeAbi, complianceHashAbi, incotermsAbi, insurancePolicyIDAbi, lcrReferenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateFinancialBl_Transactions(string description, ulong cargoValue, ulong blType, ulong creditRating, ulong riskScore, ulong yieldRate, string vleiID, string jurisdictionCode, string complianceHash, string incoterms, string insurancePolicyID, string lcrReference, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 1, 253, 35 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var cargoValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cargoValueAbi.From(cargoValue);
            var blTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blTypeAbi.From(blType);
            var creditRatingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creditRatingAbi.From(creditRating);
            var riskScoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskScoreAbi.From(riskScore);
            var yieldRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yieldRateAbi.From(yieldRate);
            var vleiIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vleiIDAbi.From(vleiID);
            var jurisdictionCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); jurisdictionCodeAbi.From(jurisdictionCode);
            var complianceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); complianceHashAbi.From(complianceHash);
            var incotermsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); incotermsAbi.From(incoterms);
            var insurancePolicyIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); insurancePolicyIDAbi.From(insurancePolicyID);
            var lcrReferenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); lcrReferenceAbi.From(lcrReference);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi, cargoValueAbi, blTypeAbi, creditRatingAbi, riskScoreAbi, yieldRateAbi, vleiIDAbi, jurisdictionCodeAbi, complianceHashAbi, incotermsAbi, insurancePolicyIDAbi, lcrReferenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get BL financial info (simplified)
        ///</summary>
        /// <param name="blId"> </param>
        public async Task<string> GetBlFinancialInfo(string blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 208, 19, 16 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetBlFinancialInfo_Transactions(string blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 208, 19, 16 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify compliance (simplified)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="regulatoryHash"> </param>
        public async Task<string> VerifyCompliance(string blId, string regulatoryHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 179, 19, 220 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var regulatoryHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); regulatoryHashAbi.From(regulatoryHash);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, regulatoryHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyCompliance_Transactions(string blId, string regulatoryHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 179, 19, 220 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var regulatoryHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); regulatoryHashAbi.From(regulatoryHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, regulatoryHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Tokenize for trading (simplified)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="fractionalShares"> </param>
        public async Task<string> TokenizeForTrading(string blId, ulong fractionalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 185, 64, 169 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var fractionalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fractionalSharesAbi.From(fractionalShares);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, fractionalSharesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TokenizeForTrading_Transactions(string blId, ulong fractionalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 185, 64, 169 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var fractionalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fractionalSharesAbi.From(fractionalShares);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, fractionalSharesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate yield (simplified)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="investmentAmount"> </param>
        public async Task<ulong> CalculateYield(string blId, ulong investmentAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 186, 236, 43 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, investmentAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateYield_Transactions(string blId, ulong investmentAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 186, 236, 43 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); blIdAbi.From(blId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, investmentAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get counter values
        ///</summary>
        public async Task<string> GetCounters(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 148, 249, 15 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetCounters_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 148, 249, 15 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVnb3RpYWJsZUZpbkJMVjEiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjoiVGVzdCBtZXRob2QgbGlrZSBIZWxsb1dvcmxkIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVGaW5hbmNpYWxCTCIsImRlc2MiOiJDcmVhdGUgRmluYW5jaWFsIEJMIChzaW1wbGlmaWVkKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZ29WYWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVkaXRSYXRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tTY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieWllbGRSYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2bGVpSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imp1cmlzZGljdGlvbkNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbXBsaWFuY2VIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmNvdGVybXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imluc3VyYW5jZVBvbGljeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsY3JSZWZlcmVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCTEZpbmFuY2lhbEluZm8iLCJkZXNjIjoiR2V0IEJMIGZpbmFuY2lhbCBpbmZvIChzaW1wbGlmaWVkKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5Q29tcGxpYW5jZSIsImRlc2MiOiJWZXJpZnkgY29tcGxpYW5jZSAoc2ltcGxpZmllZCkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVndWxhdG9yeUhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2tlbml6ZUZvclRyYWRpbmciLCJkZXNjIjoiVG9rZW5pemUgZm9yIHRyYWRpbmcgKHNpbXBsaWZpZWQpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyYWN0aW9uYWxTaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVZaWVsZCIsImRlc2MiOiJDYWxjdWxhdGUgeWllbGQgKHNpbXBsaWZpZWQpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludmVzdG1lbnRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb3VudGVycyIsImRlc2MiOiJHZXQgY291bnRlciB2YWx1ZXMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwOSwxMzMsMTYwLDE5NCwyMzAsMjYwLDM0Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMiwxMzYsMTYzLDE5NywyMzMsMjYzLDM0OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDEsNDUwLDYxOCw2MzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbUpzUTI5MWJuUmxjaUlnSW5SdmRHRnNWbUZzZFdWTWIyTnJaV1FpSUNKQ1RDQWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVG1WbmIzUnBZV0pzWlVacGJrSk1WakVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRJS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnd01tSmxZMlV4TVNBd2VEZGtNREZtWkRJeklEQjRPV0prTURFek1UQWdNSGd3TkdJek1UTmtZeUF3ZUdZeFlqazBNR0U1SURCNFpUbGlZV1ZqTW1JZ01IZ3dORGswWmprd1ppQXZMeUJ0WlhSb2IyUWdJbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1OeVpXRjBaVVpwYm1GdVkybGhiRUpNS0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBRa3hHYVc1aGJtTnBZV3hKYm1adktITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW5abGNtbG1lVU52YlhCc2FXRnVZMlVvYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luUnZhMlZ1YVhwbFJtOXlWSEpoWkdsdVp5aHpkSEpwYm1jc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTJGc1kzVnNZWFJsV1dsbGJHUW9jM1J5YVc1bkxIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRFTnZkVzUwWlhKektDbHpkSEpwYm1jaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJobGJHeHZYM0p2ZFhSbFFETWdiV0ZwYmw5amNtVmhkR1ZHYVc1aGJtTnBZV3hDVEY5eWIzVjBaVUEwSUcxaGFXNWZaMlYwUWt4R2FXNWhibU5wWVd4SmJtWnZYM0p2ZFhSbFFEVWdiV0ZwYmw5MlpYSnBabmxEYjIxd2JHbGhibU5sWDNKdmRYUmxRRFlnYldGcGJsOTBiMnRsYm1sNlpVWnZjbFJ5WVdScGJtZGZjbTkxZEdWQU55QnRZV2x1WDJOaGJHTjFiR0YwWlZscFpXeGtYM0p2ZFhSbFFEZ2diV0ZwYmw5blpYUkRiM1Z1ZEdWeWMxOXliM1YwWlVBNUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RtVm5iM1JwWVdKc1pVWnBia0pNVmpFZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFTnZkVzUwWlhKelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z1oyVjBRMjkxYm5SbGNuTW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUkRiM1Z1ZEdWeWN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJGc1kzVnNZWFJsV1dsbGJHUmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpZV3hqZFd4aGRHVlphV1ZzWkNoaWJFbGtPaUJ6ZEhKcGJtY3NJR2x1ZG1WemRHMWxiblJCYlc5MWJuUTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPWldkdmRHbGhZbXhsUm1sdVFreFdNU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZMkZzWTNWc1lYUmxXV2xsYkdRb1lteEpaRG9nYzNSeWFXNW5MQ0JwYm5abGMzUnRaVzUwUVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ1kyRnNiSE4xWWlCallXeGpkV3hoZEdWWmFXVnNaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBiMnRsYm1sNlpVWnZjbFJ5WVdScGJtZGZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QjBiMnRsYm1sNlpVWnZjbFJ5WVdScGJtY29ZbXhKWkRvZ2MzUnlhVzVuTENCbWNtRmpkR2x2Ym1Gc1UyaGhjbVZ6T2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RtVm5iM1JwWVdKc1pVWnBia0pNVmpFZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l4TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSdmEyVnVhWHBsUm05eVZISmhaR2x1WnloaWJFbGtPaUJ6ZEhKcGJtY3NJR1p5WVdOMGFXOXVZV3hUYUdGeVpYTTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhSdmEyVnVhWHBsUm05eVZISmhaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbVZ5YVdaNVEyOXRjR3hwWVc1alpWOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIWmxjbWxtZVVOdmJYQnNhV0Z1WTJVb1lteEpaRG9nYzNSeWFXNW5MQ0J5WldkMWJHRjBiM0o1U0dGemFEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTVsWjI5MGFXRmliR1ZHYVc1Q1RGWXhJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RtVnlhV1o1UTI5dGNHeHBZVzVqWlNoaWJFbGtPaUJ6ZEhKcGJtY3NJSEpsWjNWc1lYUnZjbmxJWVhOb09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUIyWlhKcFpubERiMjF3YkdsaGJtTmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkNURVpwYm1GdVkybGhiRWx1Wm05ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCblpYUkNURVpwYm1GdVkybGhiRWx1Wm04b1lteEpaRG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUU1bFoyOTBhV0ZpYkdWR2FXNUNURll4SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJuWlhSQ1RFWnBibUZ1WTJsaGJFbHVabThvWW14SlpEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFFreEdhVzVoYm1OcFlXeEpibVp2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWR2FXNWhibU5wWVd4Q1RGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3RNekVLSUNBZ0lDOHZJR055WldGMFpVWnBibUZ1WTJsaGJFSk1LQW9nSUNBZ0x5OGdJQ0JrWlhOamNtbHdkR2x2YmpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCallYSm5iMVpoYkhWbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHSnNWSGx3WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCamNtVmthWFJTWVhScGJtYzZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjbWx6YTFOamIzSmxPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSGxwWld4a1VtRjBaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0IyYkdWcFNVUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdhblZ5YVhOa2FXTjBhVzl1UTI5a1pUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQmpiMjF3YkdsaGJtTmxTR0Z6YURvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCcGJtTnZkR1Z5YlhNNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FXNXpkWEpoYm1ObFVHOXNhV041U1VRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2JHTnlVbVZtWlhKbGJtTmxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPWldkdmRHbGhZbXhsUm1sdVFreFdNU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TUFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQzB6TVFvZ0lDQWdMeThnWTNKbFlYUmxSbWx1WVc1amFXRnNRa3dvQ2lBZ0lDQXZMeUFnSUdSbGMyTnlhWEIwYVc5dU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHTmhjbWR2Vm1Gc2RXVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZbXhVZVhCbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHTnlaV1JwZEZKaGRHbHVaem9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J5YVhOclUyTnZjbVU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZVdsbGJHUlNZWFJsT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhac1pXbEpSRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JxZFhKcGMyUnBZM1JwYjI1RGIyUmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR052YlhCc2FXRnVZMlZJWVhOb09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHbHVZMjkwWlhKdGN6b2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnBibk4xY21GdVkyVlFiMnhwWTNsSlJEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnNZM0pTWldabGNtVnVZMlU2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsUm1sdVlXNWphV0ZzUWt3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2FHVnNiRzhvYm1GdFpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTVsWjI5MGFXRmliR1ZHYVc1Q1RGWXhJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5Qm9aV3hzYnlodVlXMWxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCb1pXeHNid29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l4TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFNWxaMjkwYVdGaWJHVkdhVzVDVEZZeElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUbVZuYjNScFlXSnNaVVpwYmtKTVZqRXVhR1ZzYkc4b2JtRnRaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BvWld4c2J6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5Qm9aV3hzYnlodVlXMWxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCSVpXeHNieUJtY205dElFWnBia0pNVmpFc0lDUjdibUZ0WlgxZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtobGJHeHZJR1p5YjIwZ1JtbHVRa3hXTVN3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9aV2R2ZEdsaFlteGxSbWx1UWt4V01TNWpjbVZoZEdWR2FXNWhibU5wWVd4Q1RDaGtaWE5qY21sd2RHbHZiam9nWW5sMFpYTXNJR05oY21kdlZtRnNkV1U2SUhWcGJuUTJOQ3dnWW14VWVYQmxPaUIxYVc1ME5qUXNJR055WldScGRGSmhkR2x1WnpvZ2RXbHVkRFkwTENCeWFYTnJVMk52Y21VNklIVnBiblEyTkN3Z2VXbGxiR1JTWVhSbE9pQjFhVzUwTmpRc0lIWnNaV2xKUkRvZ1lubDBaWE1zSUdwMWNtbHpaR2xqZEdsdmJrTnZaR1U2SUdKNWRHVnpMQ0JqYjIxd2JHbGhibU5sU0dGemFEb2dZbmwwWlhNc0lHbHVZMjkwWlhKdGN6b2dZbmwwWlhNc0lHbHVjM1Z5WVc1alpWQnZiR2xqZVVsRU9pQmllWFJsY3l3Z2JHTnlVbVZtWlhKbGJtTmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU55WldGMFpVWnBibUZ1WTJsaGJFSk1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd0TXpFS0lDQWdJQzh2SUdOeVpXRjBaVVpwYm1GdVkybGhiRUpNS0FvZ0lDQWdMeThnSUNCa1pYTmpjbWx3ZEdsdmJqb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQmpZWEpuYjFaaGJIVmxPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR0pzVkhsd1pUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmpjbVZrYVhSU1lYUnBibWM2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY21semExTmpiM0psT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhscFpXeGtVbUYwWlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMmJHVnBTVVE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnYW5WeWFYTmthV04wYVc5dVEyOWtaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JqYjIxd2JHbGhibU5sU0dGemFEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnBibU52ZEdWeWJYTTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdhVzV6ZFhKaGJtTmxVRzlzYVdONVNVUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdiR055VW1WbVpYSmxibU5sT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeE1pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QmliRU52ZFc1MFpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkVOdmRXNTBaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1Kc1EyOTFiblJsY2k1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdOeVpXRjBaVVpwYm1GdVkybGhiRUpNWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdZbXhEYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2RHaHBjeTVpYkVOdmRXNTBaWEl1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ21OeVpXRjBaVVpwYm1GdVkybGhiRUpNWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGWmhiSFZsVEc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTUwYjNSaGJGWmhiSFZsVEc5amEyVmtMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dZM0psWVhSbFJtbHVZVzVqYVdGc1FreGZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMGIzUmhiRlpoYkhWbFRHOWphMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkZaaGJIVmxURzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFdZV3gxWlV4dlkydGxaQzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWTNKbFlYUmxSbWx1WVc1amFXRnNRa3hmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdZbXhEYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14RGIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxtSnNRMjkxYm5SbGNpNTJZV3gxWlNBOUlIUm9hWE11WW14RGIzVnVkR1Z5TG5aaGJIVmxJQ3NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHSnNRMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14RGIzVnVkR1Z5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l4TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhSb2FYTXVZbXhEYjNWdWRHVnlMblpoYkhWbElEMGdkR2hwY3k1aWJFTnZkVzUwWlhJdWRtRnNkV1VnS3lBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RHOTBZV3hXWVd4MVpVeHZZMnRsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzVm1Gc2RXVk1iMk5yWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l4TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4V1lXeDFaVXh2WTJ0bFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFdZV3gxWlV4dlkydGxaQzUyWVd4MVpTQXJJR05oY21kdlZtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNVEVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIUnZkR0ZzVm1Gc2RXVk1iMk5yWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRlpoYkhWbFRHOWphMlZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZaaGJIVmxURzlqYTJWa0xuWmhiSFZsSUNzZ1kyRnlaMjlXWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QnlaWFIxY200Z1lFTnlaV0YwWldRZ1JtbHVZVzVqYVdGc0lFSk1JR1p2Y2lBa2UyUmxjMk55YVhCMGFXOXVmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRM0psWVhSbFpDQkdhVzVoYm1OcFlXd2dRa3dnWm05eUlDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1USUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVsWjI5MGFXRmliR1ZHYVc1Q1RGWXhMbWRsZEVKTVJtbHVZVzVqYVdGc1NXNW1ieWhpYkVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRUpNUm1sdVlXNWphV0ZzU1c1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1TOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5Qm5aWFJDVEVacGJtRnVZMmxoYkVsdVptOG9ZbXhKWkRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdSbWx1UWt3Z0pIdGliRWxrZlRvZ1JtbHVZVzVqYVdGc0lHbHVabThnWVhaaGFXeGhZbXhsWUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pHYVc1Q1RDQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSTZJRVpwYm1GdVkybGhiQ0JwYm1adklHRjJZV2xzWVdKc1pTSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVsWjI5MGFXRmliR1ZHYVc1Q1RGWXhMblpsY21sbWVVTnZiWEJzYVdGdVkyVW9ZbXhKWkRvZ1lubDBaWE1zSUhKbFozVnNZWFJ2Y25sSVlYTm9PaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblpsY21sbWVVTnZiWEJzYVdGdVkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkbVZ5YVdaNVEyOXRjR3hwWVc1alpTaGliRWxrT2lCemRISnBibWNzSUhKbFozVnNZWFJ2Y25sSVlYTm9PaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCQ1RDQWtlMkpzU1dSOUlHTnZiWEJzYVdGdVkyVWdkbVZ5YVdacFpXUmdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkNUQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWTI5dGNHeHBZVzVqWlNCMlpYSnBabWxsWkNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rNWxaMjkwYVdGaWJHVkdhVzVDVEZZeExuUnZhMlZ1YVhwbFJtOXlWSEpoWkdsdVp5aGliRWxrT2lCaWVYUmxjeXdnWm5KaFkzUnBiMjVoYkZOb1lYSmxjem9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LZEc5clpXNXBlbVZHYjNKVWNtRmthVzVuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l4TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSdmEyVnVhWHBsUm05eVZISmhaR2x1WnloaWJFbGtPaUJ6ZEhKcGJtY3NJR1p5WVdOMGFXOXVZV3hUYUdGeVpYTTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCeVpYUjFjbTRnWUVKTUlDUjdZbXhKWkgwZ2RHOXJaVzVwZW1Wa0lHWnZjaUIwY21Ga2FXNW5ZQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlRa3dnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUhSdmEyVnVhWHBsWkNCbWIzSWdkSEpoWkdsdVp5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVsWjI5MGFXRmliR1ZHYVc1Q1RGWXhMbU5oYkdOMWJHRjBaVmxwWld4a0tHSnNTV1E2SUdKNWRHVnpMQ0JwYm5abGMzUnRaVzUwUVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWTJGc1kzVnNZWFJsV1dsbGJHUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZMkZzWTNWc1lYUmxXV2xsYkdRb1lteEpaRG9nYzNSeWFXNW5MQ0JwYm5abGMzUnRaVzUwUVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2NtVjBkWEp1SUdsdWRtVnpkRzFsYm5SQmJXOTFiblFnTHlBeU1Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJREl3SUM4dklESXdDaUFnSUNBdkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRtVm5iM1JwWVdKc1pVWnBia0pNVmpFdVoyVjBRMjkxYm5SbGNuTW9LU0F0UGlCaWVYUmxjem9LWjJWMFEyOTFiblJsY25NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpFdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCaWJFTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRU52ZFc1MFpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdZMjl1YzNRZ1kyOTFiblE2SUhWcGJuUTJOQ0E5SUhSb2FYTXVZbXhEYjNWdWRHVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWliRU52ZFc1MFpYSXVkbUZzZFdVZ09pQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUkRiM1Z1ZEdWeWMxOTBaWEp1WVhKNVgyMWxjbWRsUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUdKc1EyOTFiblJsY2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNRMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtDbWRsZEVOdmRXNTBaWEp6WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGWmhiSFZsVEc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXhMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR052Ym5OMElIUjJiRG9nZFdsdWREWTBJRDBnZEdocGN5NTBiM1JoYkZaaGJIVmxURzlqYTJWa0xtaGhjMVpoYkhWbElEOGdkR2hwY3k1MGIzUmhiRlpoYkhWbFRHOWphMlZrTG5aaGJIVmxJRG9nTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwUTI5MWJuUmxjbk5mZEdWeWJtRnllVjl0WlhKblpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqRXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjBiM1JoYkZaaGJIVmxURzlqYTJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4V1lXeDFaVXh2WTJ0bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtDbWRsZEVOdmRXNTBaWEp6WDNSbGNtNWhjbmxmYldWeVoyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRU52ZFc1MFpYSnpJR0YyWVdsc1lXSnNaV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRMjkxYm5SbGNuTWdZWFpoYVd4aFlteGxJZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1CQVFWSDN4MUNXSnNRMjkxYm5SbGNoQjBiM1JoYkZaaGJIVmxURzlqYTJWa0EwSk1JREViUVFGRmdnY0VBcjdPRVFSOUFmMGpCSnZRRXhBRUJMTVQzQVR4dVVDcEJPbTY3Q3NFQkpUNUR6WWFBSTRIQU84QW1RQjdBRmNBTlFBYUFBSWlRekVaRkVReEdFU0lBZWxKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBRytGaWhNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBR0NTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQWlBRS9TUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQlZ3SUFpQUQxU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ0Z6WWFBeGMyR2dRWE5ob0ZGellhQmhjMkdnZFhBZ0EyR2doWEFnQTJHZ2xYQWdBMkdncFhBZ0EyR2d0WEFnQTJHZ3hYQWdDSUFGUkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQ0lBQmxKRlJaWEJnSk1VQ2hNVUxBalF6RVpRUDd1TVJnVVJDTkRpZ0VCZ0JSSVpXeHNieUJtY205dElFWnBia0pNVmpFc0lJdi9VSW1LREFFaUtXVkZBVUFBQXlraVp5SXFaVVVCUUFBREtpSm5JaWxsUkNNSUtVeG5JaXBsUkl2MUNDcE1aNEFaUTNKbFlYUmxaQ0JHYVc1aGJtTnBZV3dnUWt3Z1ptOXlJSXYwVUltS0FRR0FCa1pwYmtKTUlJdi9VSUFhT2lCR2FXNWhibU5wWVd3Z2FXNW1ieUJoZG1GcGJHRmliR1ZRaVlvQ0FTdUwvbENBRkNCamIyMXdiR2xoYm1ObElIWmxjbWxtYVdWa1VJbUtBZ0VyaS81UWdCWWdkRzlyWlc1cGVtVmtJR1p2Y2lCMGNtRmthVzVuVUltS0FnR0wvNEVVQ29raUtXVkZBVUVBQmlJcFpVVUJSQ0lxWlVVQlFRQUdJaXBsUlFGRWdCSkRiM1Z1ZEdWeWN5QmhkbUZwYkdGaWJHV0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
