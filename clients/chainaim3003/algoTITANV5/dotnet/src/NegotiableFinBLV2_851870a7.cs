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

namespace Arc56.Generated.chainaim3003.algoTITANV5.NegotiableFinBLV2_851870a7
{


    public class NegotiableFinBLV2Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NegotiableFinBLV2Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Test method (exact V1 compatibility)
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
        ///Enhanced Financial BL Creation (builds on V1 createFinancialBL)
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
        /// <param name="totalShares"> </param>
        /// <param name="minInvestment"> </param>
        /// <param name="dcsaVersion"> </param>
        public async Task<ulong> CreateEnhancedFinancialBl(string description, ulong cargoValue, ulong blType, ulong creditRating, ulong riskScore, ulong yieldRate, string vleiID, string jurisdictionCode, string complianceHash, string incoterms, string insurancePolicyID, string lcrReference, ulong totalShares, ulong minInvestment, string dcsaVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 104, 138, 141 };
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
            var totalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSharesAbi.From(totalShares);
            var minInvestmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minInvestmentAbi.From(minInvestment);
            var dcsaVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dcsaVersionAbi.From(dcsaVersion);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi, cargoValueAbi, blTypeAbi, creditRatingAbi, riskScoreAbi, yieldRateAbi, vleiIDAbi, jurisdictionCodeAbi, complianceHashAbi, incotermsAbi, insurancePolicyIDAbi, lcrReferenceAbi, totalSharesAbi, minInvestmentAbi, dcsaVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEnhancedFinancialBl_Transactions(string description, ulong cargoValue, ulong blType, ulong creditRating, ulong riskScore, ulong yieldRate, string vleiID, string jurisdictionCode, string complianceHash, string incoterms, string insurancePolicyID, string lcrReference, ulong totalShares, ulong minInvestment, string dcsaVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 104, 138, 141 };
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
            var totalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSharesAbi.From(totalShares);
            var minInvestmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minInvestmentAbi.From(minInvestment);
            var dcsaVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dcsaVersionAbi.From(dcsaVersion);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi, cargoValueAbi, blTypeAbi, creditRatingAbi, riskScoreAbi, yieldRateAbi, vleiIDAbi, jurisdictionCodeAbi, complianceHashAbi, incotermsAbi, insurancePolicyIDAbi, lcrReferenceAbi, totalSharesAbi, minInvestmentAbi, dcsaVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced BL information retrieval (builds on V1 getBLFinancialInfo)
        ///</summary>
        /// <param name="blId"> </param>
        public async Task<string> GetEnhancedBlInfo(ulong blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 202, 143, 64 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetEnhancedBlInfo_Transactions(ulong blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 202, 143, 64 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Fractionalization for MSME access (RWA innovation - simple implementation)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="sharesToSell"> </param>
        /// <param name="pricePerShare"> </param>
        public async Task<string> FractionalizeForTrading(ulong blId, ulong sharesToSell, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 24, 161, 180 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var sharesToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesToSellAbi.From(sharesToSell);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, sharesToSellAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> FractionalizeForTrading_Transactions(ulong blId, ulong sharesToSell, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 24, 161, 180 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var sharesToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesToSellAbi.From(sharesToSell);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, sharesToSellAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced yield calculation with risk factors (builds on V1 calculateYield)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="investmentAmount"> </param>
        /// <param name="riskAdjustment"> </param>
        public async Task<ulong> CalculateEnhancedYield(ulong blId, ulong investmentAmount, ulong riskAdjustment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 123, 44, 88 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);
            var riskAdjustmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskAdjustmentAbi.From(riskAdjustment);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, investmentAmountAbi, riskAdjustmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateEnhancedYield_Transactions(ulong blId, ulong investmentAmount, ulong riskAdjustment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 123, 44, 88 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var investmentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAmountAbi.From(investmentAmount);
            var riskAdjustmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskAdjustmentAbi.From(riskAdjustment);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, investmentAmountAbi, riskAdjustmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced compliance verification with vLEI (RWA innovation)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="vleiProof"> </param>
        /// <param name="dcsaHash"> </param>
        public async Task<string> VerifyEnhancedCompliance(ulong blId, string vleiProof, string dcsaHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 42, 85, 150 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var vleiProofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vleiProofAbi.From(vleiProof);
            var dcsaHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dcsaHashAbi.From(dcsaHash);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, vleiProofAbi, dcsaHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyEnhancedCompliance_Transactions(ulong blId, string vleiProof, string dcsaHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 42, 85, 150 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var vleiProofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vleiProofAbi.From(vleiProof);
            var dcsaHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dcsaHashAbi.From(dcsaHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, vleiProofAbi, dcsaHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cross-border settlement support (RWA innovation)
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="stablecoinAssetId"> </param>
        /// <param name="amount"> </param>
        /// <param name="targetCurrency"> </param>
        public async Task<string> InitiateCrossBorderSettlement(ulong blId, ulong stablecoinAssetId, ulong amount, string targetCurrency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 138, 24, 215 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var stablecoinAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoinAssetIdAbi.From(stablecoinAssetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var targetCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); targetCurrencyAbi.From(targetCurrency);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, stablecoinAssetIdAbi, amountAbi, targetCurrencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InitiateCrossBorderSettlement_Transactions(ulong blId, ulong stablecoinAssetId, ulong amount, string targetCurrency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 138, 24, 215 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var stablecoinAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoinAssetIdAbi.From(stablecoinAssetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var targetCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); targetCurrencyAbi.From(targetCurrency);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, stablecoinAssetIdAbi, amountAbi, targetCurrencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced counter information (builds on V1 getCounters)
        ///</summary>
        public async Task<string> GetEnhancedCounters(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 237, 214, 102 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetEnhancedCounters_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 237, 214, 102 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set marketplace contract for atomic settlement (RWA innovation)
        ///</summary>
        /// <param name="marketplaceAddress"> </param>
        public async Task<string> SetMarketplaceContract(string marketplaceAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 206, 238, 151 };
            var marketplaceAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); marketplaceAddressAbi.From(marketplaceAddress);

            var result = await base.CallApp(new List<object> { abiHandle, marketplaceAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetMarketplaceContract_Transactions(string marketplaceAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 206, 238, 151 };
            var marketplaceAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); marketplaceAddressAbi.From(marketplaceAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, marketplaceAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///User portfolio information (RWA innovation - simple implementation)
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserPortfolio(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserPortfolio_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Regulatory audit trail (RWA innovation)
        ///</summary>
        /// <param name="blId"> </param>
        public async Task<string> GenerateAuditTrail(ulong blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 233, 235, 44 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GenerateAuditTrail_Transactions(ulong blId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 233, 235, 44 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///V1 compatibility methods - exactly like V1
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
        ///
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
        ///
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
        ///
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
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVnb3RpYWJsZUZpbkJMVjIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjoiVGVzdCBtZXRob2QgKGV4YWN0IFYxIGNvbXBhdGliaWxpdHkpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVFbmhhbmNlZEZpbmFuY2lhbEJMIiwiZGVzYyI6IkVuaGFuY2VkIEZpbmFuY2lhbCBCTCBDcmVhdGlvbiAoYnVpbGRzIG9uIFYxIGNyZWF0ZUZpbmFuY2lhbEJMKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FyZ29WYWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVkaXRSYXRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tTY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieWllbGRSYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2bGVpSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imp1cmlzZGljdGlvbkNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbXBsaWFuY2VIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmNvdGVybXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imluc3VyYW5jZVBvbGljeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsY3JSZWZlcmVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5JbnZlc3RtZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkY3NhVmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVuaGFuY2VkQkxJbmZvIiwiZGVzYyI6IkVuaGFuY2VkIEJMIGluZm9ybWF0aW9uIHJldHJpZXZhbCAoYnVpbGRzIG9uIFYxIGdldEJMRmluYW5jaWFsSW5mbykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZyYWN0aW9uYWxpemVGb3JUcmFkaW5nIiwiZGVzYyI6IkZyYWN0aW9uYWxpemF0aW9uIGZvciBNU01FIGFjY2VzcyAoUldBIGlubm92YXRpb24gLSBzaW1wbGUgaW1wbGVtZW50YXRpb24pIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlc1RvU2VsbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VQZXJTaGFyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZUVuaGFuY2VkWWllbGQiLCJkZXNjIjoiRW5oYW5jZWQgeWllbGQgY2FsY3VsYXRpb24gd2l0aCByaXNrIGZhY3RvcnMgKGJ1aWxkcyBvbiBWMSBjYWxjdWxhdGVZaWVsZCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW52ZXN0bWVudEFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza0FkanVzdG1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlFbmhhbmNlZENvbXBsaWFuY2UiLCJkZXNjIjoiRW5oYW5jZWQgY29tcGxpYW5jZSB2ZXJpZmljYXRpb24gd2l0aCB2TEVJIChSV0EgaW5ub3ZhdGlvbikiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmxlaVByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkY3NhSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRpYXRlQ3Jvc3NCb3JkZXJTZXR0bGVtZW50IiwiZGVzYyI6IkNyb3NzLWJvcmRlciBzZXR0bGVtZW50IHN1cHBvcnQgKFJXQSBpbm5vdmF0aW9uKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFibGVjb2luQXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRDdXJyZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVuaGFuY2VkQ291bnRlcnMiLCJkZXNjIjoiRW5oYW5jZWQgY291bnRlciBpbmZvcm1hdGlvbiAoYnVpbGRzIG9uIFYxIGdldENvdW50ZXJzKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldE1hcmtldHBsYWNlQ29udHJhY3QiLCJkZXNjIjoiU2V0IG1hcmtldHBsYWNlIGNvbnRyYWN0IGZvciBhdG9taWMgc2V0dGxlbWVudCAoUldBIGlubm92YXRpb24pIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJQb3J0Zm9saW8iLCJkZXNjIjoiVXNlciBwb3J0Zm9saW8gaW5mb3JtYXRpb24gKFJXQSBpbm5vdmF0aW9uIC0gc2ltcGxlIGltcGxlbWVudGF0aW9uKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdlbmVyYXRlQXVkaXRUcmFpbCIsImRlc2MiOiJSZWd1bGF0b3J5IGF1ZGl0IHRyYWlsIChSV0EgaW5ub3ZhdGlvbikiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEJMRmluYW5jaWFsSW5mbyIsImRlc2MiOiJWMSBjb21wYXRpYmlsaXR5IG1ldGhvZHMgLSBleGFjdGx5IGxpa2UgVjEiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeUNvbXBsaWFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVndWxhdG9yeUhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2tlbml6ZUZvclRyYWRpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJhY3Rpb25hbFNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZVlpZWxkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludmVzdG1lbnRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb3VudGVycyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg3LDI1OSwyODYsMzIwLDM1NiwzODYsNDYxLDUzMyw2MTMsNjkzLDc3NSw4NTIsODgxLDk1NSwxMDQ1LDExMzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTczXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwLDI2MiwyODksMzIzLDM1OSwzODksNDY0LDUzNiw2MTYsNjk2LDc3OCw4NTUsODg0LDk1OCwxMDQ4LDExNDFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1MywxMjYyLDEyNjYsMTI3Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0ltSnNRMjkxYm5SbGNpSWdJblJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWlJQ0owYjNSaGJFSk1jMEZqZEdsMlpTSWdJa0pNSUNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk9aV2R2ZEdsaFlteGxSbWx1UWt4V01pQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXlNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREF5WW1WalpURXhJREI0TkdRMk9EaGhPR1FnTUhobFkyTmhPR1kwTUNBd2VETXdNVGhoTVdJMElEQjRNR1kzWWpKak5UZ2dNSGhqWWpKaE5UVTVOaUF3ZUdVNE9HRXhPR1EzSURCNE5UTmxaR1EyTmpZZ01IaGlaR05sWldVNU55QXdlR1ppTUdJMFpUWXpJREI0Tm1KbE9XVmlNbU1nTUhnNVltUXdNVE14TUNBd2VEQTBZak14TTJSaklEQjRaakZpT1RRd1lUa2dNSGhsT1dKaFpXTXlZaUF3ZURBME9UUm1PVEJtSUM4dklHMWxkR2h2WkNBaWFHVnNiRzhvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZM0psWVhSbFJXNW9ZVzVqWldSR2FXNWhibU5wWVd4Q1RDaHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRFVnVhR0Z1WTJWa1FreEpibVp2S0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbVp5WVdOMGFXOXVZV3hwZW1WR2IzSlVjbUZrYVc1bktIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMkZzWTNWc1lYUmxSVzVvWVc1alpXUlphV1ZzWkNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVVWdWFHRnVZMlZrUTI5dGNHeHBZVzVqWlNoMWFXNTBOalFzYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltbHVhWFJwWVhSbFEzSnZjM05DYjNKa1pYSlRaWFIwYkdWdFpXNTBLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEVWdWFHRnVZMlZrUTI5MWJuUmxjbk1vS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpYzJWMFRXRnlhMlYwY0d4aFkyVkRiMjUwY21GamRDaHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUlZjMlZ5VUc5eWRHWnZiR2x2S0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsYm1WeVlYUmxRWFZrYVhSVWNtRnBiQ2gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJDVEVacGJtRnVZMmxoYkVsdVptOG9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWRtVnlhV1o1UTI5dGNHeHBZVzVqWlNoemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkRzlyWlc1cGVtVkdiM0pVY21Ga2FXNW5LSE4wY21sdVp5eDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKallXeGpkV3hoZEdWWmFXVnNaQ2h6ZEhKcGJtY3NkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRMjkxYm5SbGNuTW9LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmFHVnNiRzlmY205MWRHVkFNeUJ0WVdsdVgyTnlaV0YwWlVWdWFHRnVZMlZrUm1sdVlXNWphV0ZzUWt4ZmNtOTFkR1ZBTkNCdFlXbHVYMmRsZEVWdWFHRnVZMlZrUWt4SmJtWnZYM0p2ZFhSbFFEVWdiV0ZwYmw5bWNtRmpkR2x2Ym1Gc2FYcGxSbTl5VkhKaFpHbHVaMTl5YjNWMFpVQTJJRzFoYVc1ZlkyRnNZM1ZzWVhSbFJXNW9ZVzVqWldSWmFXVnNaRjl5YjNWMFpVQTNJRzFoYVc1ZmRtVnlhV1o1Ulc1b1lXNWpaV1JEYjIxd2JHbGhibU5sWDNKdmRYUmxRRGdnYldGcGJsOXBibWwwYVdGMFpVTnliM056UW05eVpHVnlVMlYwZEd4bGJXVnVkRjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBSVzVvWVc1alpXUkRiM1Z1ZEdWeWMxOXliM1YwWlVBeE1DQnRZV2x1WDNObGRFMWhjbXRsZEhCc1lXTmxRMjl1ZEhKaFkzUmZjbTkxZEdWQU1URWdiV0ZwYmw5blpYUlZjMlZ5VUc5eWRHWnZiR2x2WDNKdmRYUmxRREV5SUcxaGFXNWZaMlZ1WlhKaGRHVkJkV1JwZEZSeVlXbHNYM0p2ZFhSbFFERXpJRzFoYVc1ZloyVjBRa3hHYVc1aGJtTnBZV3hKYm1adlgzSnZkWFJsUURFMElHMWhhVzVmZG1WeWFXWjVRMjl0Y0d4cFlXNWpaVjl5YjNWMFpVQXhOU0J0WVdsdVgzUnZhMlZ1YVhwbFJtOXlWSEpoWkdsdVoxOXliM1YwWlVBeE5pQnRZV2x1WDJOaGJHTjFiR0YwWlZscFpXeGtYM0p2ZFhSbFFERTNJRzFoYVc1ZloyVjBRMjkxYm5SbGNuTmZjbTkxZEdWQU1UZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk9aV2R2ZEdsaFlteGxSbWx1UWt4V01pQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRMjkxYm5SbGNuTmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFVLSUNBZ0lDOHZJR2RsZEVOdmRXNTBaWEp6S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBek5qUTFObVUyT0RZeE5tVTJNelkxTmpReU1EWXpObVkzTlRabE56UTJOVGN5TnpNeU1EWXhOelkyTVRZNU5tTTJNVFl5Tm1NMk5USXdOemMyT1RjME5qZ3lNRFl4TmpRMk5EWTVOelEyT1RabU5tVTJNVFpqTWpBMU5qTXlNakEyWkRZMU56UTNNalk1TmpNM013b2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJHTjFiR0YwWlZscFpXeGtYM0p2ZFhSbFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3Q2lBZ0lDQXZMeUJqWVd4amRXeGhkR1ZaYVdWc1pDaGliRWxrT2lCemRISnBibWNzSUdsdWRtVnpkRzFsYm5SQmJXOTFiblE2SUhWcGJuUTJOQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCT1pXZHZkR2xoWW14bFJtbHVRa3hXTWlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRBS0lDQWdJQzh2SUdOaGJHTjFiR0YwWlZscFpXeGtLR0pzU1dRNklITjBjbWx1Wnl3Z2FXNTJaWE4wYldWdWRFRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxXV2xsYkdRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEc5clpXNXBlbVZHYjNKVWNtRmthVzVuWDNKdmRYUmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRMkNpQWdJQ0F2THlCMGIydGxibWw2WlVadmNsUnlZV1JwYm1jb1lteEpaRG9nYzNSeWFXNW5MQ0JtY21GamRHbHZibUZzVTJoaGNtVnpPaUIxYVc1ME5qUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVG1WbmIzUnBZV0pzWlVacGJrSk1WaklnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUIwYjJ0bGJtbDZaVVp2Y2xSeVlXUnBibWNvWW14SlpEb2djM1J5YVc1bkxDQm1jbUZqZEdsdmJtRnNVMmhoY21Wek9pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUIwYjJ0bGJtbDZaVVp2Y2xSeVlXUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzWmxjbWxtZVVOdmJYQnNhV0Z1WTJWZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklIWmxjbWxtZVVOdmJYQnNhV0Z1WTJVb1lteEpaRG9nYzNSeWFXNW5MQ0J5WldkMWJHRjBiM0o1U0dGemFEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTVsWjI5MGFXRmliR1ZHYVc1Q1RGWXlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklIWmxjbWxtZVVOdmJYQnNhV0Z1WTJVb1lteEpaRG9nYzNSeWFXNW5MQ0J5WldkMWJHRjBiM0o1U0dGemFEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnZG1WeWFXWjVRMjl0Y0d4cFlXNWpaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRa3hHYVc1aGJtTnBZV3hKYm1adlgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTRDaUFnSUNBdkx5Qm5aWFJDVEVacGJtRnVZMmxoYkVsdVptOG9ZbXhKWkRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFNWxaMjkwYVdGaWJHVkdhVzVDVEZZeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Bb2dJQ0FnTHk4Z1oyVjBRa3hHYVc1aGJtTnBZV3hKYm1adktHSnNTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRUpNUm1sdVlXNWphV0ZzU1c1bWJ3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWdVpYSmhkR1ZCZFdScGRGUnlZV2xzWDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCblpXNWxjbUYwWlVGMVpHbDBWSEpoYVd3b1lteEpaRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNRE01TkRFM05UWTBOamszTkRJd05UUTNNall4TmprMll6TmhNakEwT1Raa05tUTNOVGMwTmpFMk1qWmpOalV5TURZek5tWTJaRGN3Tm1NMk9UWXhObVUyTXpZMU1qQTNNalkxTmpNMlpqY3lOalF5TURZM05qVTJaVFkxTnpJMk1UYzBOalUyTkRJd05qWTJaamN5TWpBME1qUmpDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWWE5sY2xCdmNuUm1iMnhwYjE5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5Bb2dJQ0FnTHk4Z1oyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ETTJOVFUzTXpZMU56SXlNRFV3Tm1ZM01qYzBOalkyWmpaak5qazJaakl3TmpRMk1UYzBOakV5TURZeE56WTJNVFk1Tm1NMk1UWXlObU0yTlRJd05qWTJaamN5TWpBMk5UWmxOamcyTVRabE5qTTJOVFkwTWpBME1qUmpNakEzTkRjeU5qRTJNelppTmprMlpUWTNDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBUV0Z5YTJWMGNHeGhZMlZEYjI1MGNtRmpkRjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnYzJWMFRXRnlhMlYwY0d4aFkyVkRiMjUwY21GamRDaHRZWEpyWlhSd2JHRmpaVUZrWkhKbGMzTTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXpaVFJrTmpFM01qWmlOalUzTkRjd05tTTJNVFl6TmpVeU1EWXpObVkyWlRjME56STJNVFl6TnpReU1EWmpOamsyWlRaaU5qVTJOREl3TmpZMlpqY3lNakEyTVRjME5tWTJaRFk1TmpNeU1EY3pOalUzTkRjME5tTTJOVFprTmpVMlpUYzBNakEyTXpZeE56QTJNVFl5TmprMll6WTVOelEyT1RZMU56TUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkZibWhoYm1ObFpFTnZkVzUwWlhKelgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5Qm5aWFJGYm1oaGJtTmxaRU52ZFc1MFpYSnpLQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF6WlRRMU5tVTJPRFl4Tm1VMk16WTFOalF5TURRek5tWTNOVFpsTnpRMk5UY3lOek15TURZeE56WTJNVFk1Tm1NMk1UWXlObU0yTlRJd056YzJPVGMwTmpneU1EUXlOR015TURZek5tWTNOVFpsTnpReVl6SXdOVFExTmpSak1tTXlNRFl4Tm1VMk5ESXdOakUyTXpjME5qazNOalkxTWpBME1qUmpOek1LSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBibWwwYVdGMFpVTnliM056UW05eVpHVnlVMlYwZEd4bGJXVnVkRjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGd0TVRBekNpQWdJQ0F2THlCcGJtbDBhV0YwWlVOeWIzTnpRbTl5WkdWeVUyVjBkR3hsYldWdWRDZ0tJQ0FnSUM4dklDQWdZbXhKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCemRHRmliR1ZqYjJsdVFYTnpaWFJKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZEdGeVoyVjBRM1Z5Y21WdVkzazZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EUXdORE0zTWpabU56TTNNekprTmpJMlpqY3lOalEyTlRjeU1qQTNNelkxTnpRM05EWmpOalUyWkRZMU5tVTNOREl3TmprMlpUWTVOelEyT1RZeE56UTJOVFkwTWpBMk5qWm1Oekl5TURReU5HTXlNRGMzTmprM05EWTRNakEzTXpjME5qRTJNalpqTmpVMk16Wm1OamsyWlRJd056TTNOVGN3TnpBMlpqY3lOelFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTJaWEpwWm5sRmJtaGhibU5sWkVOdmJYQnNhV0Z1WTJWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCMlpYSnBabmxGYm1oaGJtTmxaRU52YlhCc2FXRnVZMlVvWW14SlpEb2dkV2x1ZERZMExDQjJiR1ZwVUhKdmIyWTZJSE4wY21sdVp5d2daR056WVVoaGMyZzZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXpZalF5TkdNeU1EWXpObVkyWkRjd05tTTJPVFl4Tm1VMk16WTFNakEzTmpZMU56STJPVFkyTmprMk5UWTBNMkV5TURjMk5HTTBOVFE1TWpBeVlqSXdORFEwTXpVek5ERXlNRE16TW1Vek1ESXdOelkyTVRaak5qazJORFl4TnpRMk9UWm1ObVV5TURZek5tWTJaRGN3Tm1NMk5UYzBOalVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpZV3hqZFd4aGRHVkZibWhoYm1ObFpGbHBaV3hrWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWTJGc1kzVnNZWFJsUlc1b1lXNWpaV1JaYVdWc1pDaGliRWxrT2lCMWFXNTBOalFzSUdsdWRtVnpkRzFsYm5SQmJXOTFiblE2SUhWcGJuUTJOQ3dnY21semEwRmthblZ6ZEcxbGJuUTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPWldkdmRHbGhZbXhsUm1sdVFreFdNaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJqWVd4amRXeGhkR1ZGYm1oaGJtTmxaRmxwWld4a0tHSnNTV1E2SUhWcGJuUTJOQ3dnYVc1MlpYTjBiV1Z1ZEVGdGIzVnVkRG9nZFdsdWREWTBMQ0J5YVhOclFXUnFkWE4wYldWdWREb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUdOaGJHeHpkV0lnWTJGc1kzVnNZWFJsUlc1b1lXNWpaV1JaYVdWc1pBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bWNtRmpkR2x2Ym1Gc2FYcGxSbTl5VkhKaFpHbHVaMTl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR1p5WVdOMGFXOXVZV3hwZW1WR2IzSlVjbUZrYVc1bktHSnNTV1E2SUhWcGJuUTJOQ3dnYzJoaGNtVnpWRzlUWld4c09pQjFhVzUwTmpRc0lIQnlhV05sVUdWeVUyaGhjbVU2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF6T0RReU5HTXlNRFkyTnpJMk1UWXpOelEyT1RabU5tVTJNVFpqTmprM1lUWTFOalF5TURjM05qazNORFk0TWpBM016WTROakUzTWpZMU56TXlNRFl4TnpZMk1UWTVObU0yTVRZeU5tTTJOVEl3TmpZMlpqY3lNakEwWkRVek5HUTBOVEl3TnpRM01qWXhOalEyT1RabE5qY0tJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkZibWhoYm1ObFpFSk1TVzVtYjE5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdkbGRFVnVhR0Z1WTJWa1FreEpibVp2S0dKc1NXUTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQTBPRFExTm1VMk9EWXhObVUyTXpZMU5qUXlNRFEyTmprMlpUUXlOR016WVRJd05ERTJORGMyTmpFMlpUWXpOalUyTkRJd05qWTJPVFpsTmpFMlpUWXpOamsyTVRaak1qQTJPVFpsTmpZMlpqSXdOemMyT1RjME5qZ3lNRFkyTnpJMk1UWXpOelEyT1RabU5tVTJNVFpqTmprM1lUWXhOelEyT1RabU5tVXlNRFl4TnpZMk1UWTVObU0yTVRZeU5tTTJOUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlVWdWFHRnVZMlZrUm1sdVlXNWphV0ZzUWt4ZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUxUTTVDaUFnSUNBdkx5QmpjbVZoZEdWRmJtaGhibU5sWkVacGJtRnVZMmxoYkVKTUtBb2dJQ0FnTHk4Z0lDQmtaWE5qY21sd2RHbHZiam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JqWVhKbmIxWmhiSFZsT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdKc1ZIbHdaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JqY21Wa2FYUlNZWFJwYm1jNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NtbHphMU5qYjNKbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lIbHBaV3hrVW1GMFpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQjJiR1ZwU1VRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FuVnlhWE5rYVdOMGFXOXVRMjlrWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCamIyMXdiR2xoYm1ObFNHRnphRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JwYm1OdmRHVnliWE02SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnYVc1emRYSmhibU5sVUc5c2FXTjVTVVE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnYkdOeVVtVm1aWEpsYm1ObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDOHZJRll5SUdWdWFHRnVZMlZ0Wlc1MGN5QW9jMmx0Y0d4bElIQmhjbUZ0WlhSbGNuTXBDaUFnSUNBdkx5QWdJSFJ2ZEdGc1UyaGhjbVZ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUcxcGJrbHVkbVZ6ZEcxbGJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdaR056WVZabGNuTnBiMjQ2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUU1bFoyOTBhV0ZpYkdWR2FXNUNURll5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ09Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWkwek9Rb2dJQ0FnTHk4Z1kzSmxZWFJsUlc1b1lXNWpaV1JHYVc1aGJtTnBZV3hDVENnS0lDQWdJQzh2SUNBZ1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZMkZ5WjI5V1lXeDFaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JpYkZSNWNHVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZM0psWkdsMFVtRjBhVzVuT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKcGMydFRZMjl5WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCNWFXVnNaRkpoZEdVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2RteGxhVWxFT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUdwMWNtbHpaR2xqZEdsdmJrTnZaR1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWTI5dGNHeHBZVzVqWlVoaGMyZzZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdhVzVqYjNSbGNtMXpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR2x1YzNWeVlXNWpaVkJ2YkdsamVVbEVPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR3hqY2xKbFptVnlaVzVqWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBdkx5QldNaUJsYm1oaGJtTmxiV1Z1ZEhNZ0tITnBiWEJzWlNCd1lYSmhiV1YwWlhKektRb2dJQ0FnTHk4Z0lDQjBiM1JoYkZOb1lYSmxjem9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0YVc1SmJuWmxjM1J0Wlc1ME9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHUmpjMkZXWlhKemFXOXVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVVZ1YUdGdVkyVmtSbWx1WVc1amFXRnNRa3dLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhR1ZzYkc5ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCb1pXeHNieWh1WVcxbE9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUbVZuYjNScFlXSnNaVVpwYmtKTVZqSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHaGxiR3h2S0c1aGJXVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdobGJHeHZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNakU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RtVm5iM1JwWVdKc1pVWnBia0pNVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREkxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9aV2R2ZEdsaFlteGxSbWx1UWt4V01pNW9aV3hzYnlodVlXMWxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWhsYkd4dk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHaGxiR3h2S0c1aGJXVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCeVpYUjFjbTRnWUVobGJHeHZJR1p5YjIwZ1JtbHVRa3hXTWlCRmJtaGhibU5sWkN3Z0pIdHVZVzFsZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpU0dWc2JHOGdabkp2YlNCR2FXNUNURll5SUVWdWFHRnVZMlZrTENBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rNWxaMjkwYVdGaWJHVkdhVzVDVEZZeUxtTnlaV0YwWlVWdWFHRnVZMlZrUm1sdVlXNWphV0ZzUWt3b1pHVnpZM0pwY0hScGIyNDZJR0o1ZEdWekxDQmpZWEpuYjFaaGJIVmxPaUIxYVc1ME5qUXNJR0pzVkhsd1pUb2dkV2x1ZERZMExDQmpjbVZrYVhSU1lYUnBibWM2SUhWcGJuUTJOQ3dnY21semExTmpiM0psT2lCMWFXNTBOalFzSUhscFpXeGtVbUYwWlRvZ2RXbHVkRFkwTENCMmJHVnBTVVE2SUdKNWRHVnpMQ0JxZFhKcGMyUnBZM1JwYjI1RGIyUmxPaUJpZVhSbGN5d2dZMjl0Y0d4cFlXNWpaVWhoYzJnNklHSjVkR1Z6TENCcGJtTnZkR1Z5YlhNNklHSjVkR1Z6TENCcGJuTjFjbUZ1WTJWUWIyeHBZM2xKUkRvZ1lubDBaWE1zSUd4amNsSmxabVZ5Wlc1alpUb2dZbmwwWlhNc0lIUnZkR0ZzVTJoaGNtVnpPaUIxYVc1ME5qUXNJRzFwYmtsdWRtVnpkRzFsYm5RNklIVnBiblEyTkN3Z1pHTnpZVlpsY25OcGIyNDZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbU55WldGMFpVVnVhR0Z1WTJWa1JtbHVZVzVqYVdGc1FrdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNaTB6T1FvZ0lDQWdMeThnWTNKbFlYUmxSVzVvWVc1alpXUkdhVzVoYm1OcFlXeENUQ2dLSUNBZ0lDOHZJQ0FnWkdWelkzSnBjSFJwYjI0NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ1kyRnlaMjlXWVd4MVpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmliRlI1Y0dVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1kzSmxaR2wwVW1GMGFXNW5PaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEpwYzJ0VFkyOXlaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0I1YVdWc1pGSmhkR1U2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZG14bGFVbEVPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR3AxY21selpHbGpkR2x2YmtOdlpHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZMjl0Y0d4cFlXNWpaVWhoYzJnNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2FXNWpiM1JsY20xek9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHbHVjM1Z5WVc1alpWQnZiR2xqZVVsRU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHeGpjbEpsWm1WeVpXNWpaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0F2THlCV01pQmxibWhoYm1ObGJXVnVkSE1nS0hOcGJYQnNaU0J3WVhKaGJXVjBaWEp6S1FvZ0lDQWdMeThnSUNCMGIzUmhiRk5vWVhKbGN6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRhVzVKYm5abGMzUnRaVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdSamMyRldaWEp6YVc5dU9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXhOU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJpYkVOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtSnNRMjkxYm5SbGNpNW9ZWE5XWVd4MVpTa2dld29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHTnlaV0YwWlVWdWFHRnVZMlZrUm1sdVlXNWphV0ZzUWt4ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJpYkVOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNRMjkxYm5SbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBhR2x6TG1Kc1EyOTFiblJsY2k1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1kzSmxZWFJsUlc1b1lXNWpaV1JHYVc1aGJtTnBZV3hDVEY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUIwYjNSaGJGWmhiSFZsVEc5amEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeFdZV3gxWlV4dlkydGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11ZEc5MFlXeFdZV3gxWlV4dlkydGxaQzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR055WldGMFpVVnVhR0Z1WTJWa1JtbHVZVzVqYVdGc1FreGZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMGIzUmhiRlpoYkhWbFRHOWphMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkZaaGJIVmxURzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFdZV3gxWlV4dlkydGxaQzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWTNKbFlYUmxSVzVvWVc1alpXUkdhVzVoYm1OcFlXeENURjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QjBiM1JoYkVKTWMwRmpkR2wyWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzUWt4elFXTjBhWFpsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1MGIzUmhiRUpNYzBGamRHbDJaUzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR055WldGMFpVVnVhR0Z1WTJWa1JtbHVZVzVqYVdGc1FreGZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMGIzUmhiRUpNYzBGamRHbDJaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hDVEhOQlkzUnBkbVVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVKTWMwRmpkR2wyWlM1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1kzSmxZWFJsUlc1b1lXNWpaV1JHYVc1aGJtTnBZV3hDVEY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJpYkVOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJFTnZkVzUwWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhSb2FYTXVZbXhEYjNWdWRHVnlMblpoYkhWbElEMGdkR2hwY3k1aWJFTnZkVzUwWlhJdWRtRnNkV1VnS3lBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdZbXhEYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WbmIzUnBZV0pzWlY5bWFXNWZZbXhmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2RHaHBjeTVpYkVOdmRXNTBaWEl1ZG1Gc2RXVWdQU0IwYUdsekxtSnNRMjkxYm5SbGNpNTJZV3gxWlNBcklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QmliRU52ZFc1MFpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkVOdmRXNTBaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdkRzkwWVd4V1lXeDFaVXh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bFoyOTBhV0ZpYkdWZlptbHVYMkpzWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFdZV3gxWlV4dlkydGxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hXWVd4MVpVeHZZMnRsWkM1MllXeDFaU0FySUdOaGNtZHZWbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVRRS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFJ2ZEdGc1ZtRnNkV1ZNYjJOclpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNWbUZzZFdWTWIyTnJaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZaaGJIVmxURzlqYTJWa0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJGWmhiSFZsVEc5amEyVmtMblpoYkhWbElDc2dZMkZ5WjI5V1lXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSFJ2ZEdGc1FreHpRV04wYVhabElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4Q1RITkJZM1JwZG1VaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4Q1RITkJZM1JwZG1VdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1FreHpRV04wYVhabExuWmhiSFZsSUNzZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSFJ2ZEdGc1FreHpRV04wYVhabElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJFSk1jMEZqZEdsMlpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNRa3h6UVdOMGFYWmxMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRUpNYzBGamRHbDJaUzUyWVd4MVpTQXJJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnY21WMGRYSnVJRzVsZDBKTVNXUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9aV2R2ZEdsaFlteGxSbWx1UWt4V01pNWpZV3hqZFd4aGRHVkZibWhoYm1ObFpGbHBaV3hrS0dKc1NXUTZJSFZwYm5RMk5Dd2dhVzUyWlhOMGJXVnVkRUZ0YjNWdWREb2dkV2x1ZERZMExDQnlhWE5yUVdScWRYTjBiV1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtTmhiR04xYkdGMFpVVnVhR0Z1WTJWa1dXbGxiR1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWTJGc1kzVnNZWFJsUlc1b1lXNWpaV1JaYVdWc1pDaGliRWxrT2lCMWFXNTBOalFzSUdsdWRtVnpkRzFsYm5SQmJXOTFiblE2SUhWcGJuUTJOQ3dnY21semEwRmthblZ6ZEcxbGJuUTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WldkdmRHbGhZbXhsWDJacGJsOWliRjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCamIyNXpkQ0JpWVhObFdXbGxiR1E2SUhWcGJuUTJOQ0E5SUdsdWRtVnpkRzFsYm5SQmJXOTFiblFnTHlBeU1DQXZMeUExSlNCaVlYTmxJQ2hXTVNCd1lYUjBaWEp1S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESXdJQzh2SURJd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnY21WMGRYSnVJR0poYzJWWmFXVnNaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazVsWjI5MGFXRmliR1ZHYVc1Q1RGWXlMbWRsZEVKTVJtbHVZVzVqYVdGc1NXNW1ieWhpYkVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRUpNUm1sdVlXNWphV0ZzU1c1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdaMlYwUWt4R2FXNWhibU5wWVd4SmJtWnZLR0pzU1dRNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnY21WMGRYSnVJR0JHYVc1Q1RDQWtlMkpzU1dSOU9pQkZibWhoYm1ObFpDQm1hVzVoYm1OcFlXd2dhVzVtYnlCaGRtRnBiR0ZpYkdWZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtacGJrSk1JQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJam9nUlc1b1lXNWpaV1FnWm1sdVlXNWphV0ZzSUdsdVptOGdZWFpoYVd4aFlteGxJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VG1WbmIzUnBZV0pzWlVacGJrSk1Wakl1ZG1WeWFXWjVRMjl0Y0d4cFlXNWpaU2hpYkVsa09pQmllWFJsY3l3Z2NtVm5kV3hoZEc5eWVVaGhjMmc2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZG1WeWFXWjVRMjl0Y0d4cFlXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnZG1WeWFXWjVRMjl0Y0d4cFlXNWpaU2hpYkVsa09pQnpkSEpwYm1jc0lISmxaM1ZzWVhSdmNubElZWE5vT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVm5iM1JwWVdKc1pWOW1hVzVmWW14ZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmdRa3dnSkh0aWJFbGtmU0JsYm1oaGJtTmxaQ0JqYjIxd2JHbGhibU5sSUhabGNtbG1hV1ZrWUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpUWt3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlHVnVhR0Z1WTJWa0lHTnZiWEJzYVdGdVkyVWdkbVZ5YVdacFpXUWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaV2R2ZEdsaFlteGxYMlpwYmw5aWJGOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBPWldkdmRHbGhZbXhsUm1sdVFreFdNaTUwYjJ0bGJtbDZaVVp2Y2xSeVlXUnBibWNvWW14SlpEb2dZbmwwWlhNc0lHWnlZV04wYVc5dVlXeFRhR0Z5WlhNNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuUnZhMlZ1YVhwbFJtOXlWSEpoWkdsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpXZHZkR2xoWW14bFgyWnBibDlpYkY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdkRzlyWlc1cGVtVkdiM0pVY21Ga2FXNW5LR0pzU1dRNklITjBjbWx1Wnl3Z1puSmhZM1JwYjI1aGJGTm9ZWEpsY3pvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRUpNSUNSN1lteEpaSDBnWlc1b1lXNWpaV1FnZEc5clpXNXBlbUYwYVc5dUlHWnZjaUIwY21Ga2FXNW5ZQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlRa3dnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdWdWFHRnVZMlZrSUhSdmEyVnVhWHBoZEdsdmJpQm1iM0lnZEhKaFpHbHVaeUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsWjI5MGFXRmliR1ZmWm1sdVgySnNYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1bFoyOTBhV0ZpYkdWR2FXNUNURll5TG1OaGJHTjFiR0YwWlZscFpXeGtLR0pzU1dRNklHSjVkR1Z6TENCcGJuWmxjM1J0Wlc1MFFXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1kyRnNZM1ZzWVhSbFdXbGxiR1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVZuYjNScFlXSnNaVjltYVc1ZllteGZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRBS0lDQWdJQzh2SUdOaGJHTjFiR0YwWlZscFpXeGtLR0pzU1dRNklITjBjbWx1Wnl3Z2FXNTJaWE4wYldWdWRFRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxaMjkwYVdGaWJHVmZabWx1WDJKc1gzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdhVzUyWlhOMGJXVnVkRUZ0YjNWdWRDQXZJREUzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UY2dMeThnTVRjS0lDQWdJQzhLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1CUVFWSDN4MUNXSnNRMjkxYm5SbGNoQjBiM1JoYkZaaGJIVmxURzlqYTJWa0RuUnZkR0ZzUWt4elFXTjBhWFpsQTBKTUlERWJRUVJPZ2hBRUFyN09FUVJOYUlxTkJPektqMEFFTUJpaHRBUVBleXhZQk1zcVZaWUU2SW9ZMXdSVDdkWm1CTDNPN3BjRSt3dE9Zd1JyNmVzc0JKdlFFeEFFQkxNVDNBVHh1VUNwQk9tNjdDc0VCSlQ1RHpZYUFJNFFBN2tEWEFNQ0FyZ0Ntd0pPQWZ3QnJBRmNBUlFBeVFDckFJY0FaUUJLQUFJalF6RVpGRVF4R0VTQVBCVWZmSFVBTmtWdWFHRnVZMlZrSUdOdmRXNTBaWEp6SUdGMllXbHNZV0pzWlNCM2FYUm9JR0ZrWkdsMGFXOXVZV3dnVmpJZ2JXVjBjbWxqYzdBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBU0VGaWhNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBUTdTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQWlBUHVTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFpQU9iU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRWdEOFZIM3gxQURsQmRXUnBkQ0JVY21GcGJEb2dTVzF0ZFhSaFlteGxJR052YlhCc2FXRnVZMlVnY21WamIzSmtJR2RsYm1WeVlYUmxaQ0JtYjNJZ1FreXdJa014R1JSRU1SaEVnRHdWSDN4MUFEWlZjMlZ5SUZCdmNuUm1iMnhwYnlCa1lYUmhJR0YyWVdsc1lXSnNaU0JtYjNJZ1pXNW9ZVzVqWldRZ1Frd2dkSEpoWTJ0cGJtZXdJa014R1JSRU1SaEVnRVFWSDN4MUFENU5ZWEpyWlhSd2JHRmpaU0JqYjI1MGNtRmpkQ0JzYVc1clpXUWdabTl5SUdGMGIyMXBZeUJ6WlhSMGJHVnRaVzUwSUdOaGNHRmlhV3hwZEdsbGM3QWlRekVaRkVReEdFU0FSQlVmZkhVQVBrVnVhR0Z1WTJWa0lFTnZkVzUwWlhKeklHRjJZV2xzWVdKc1pTQjNhWFJvSUVKTUlHTnZkVzUwTENCVVZrd3NJR0Z1WkNCaFkzUnBkbVVnUWt4enNDSkRNUmtVUkRFWVJJQkdGUjk4ZFFCQVEzSnZjM010WW05eVpHVnlJSE5sZEhSc1pXMWxiblFnYVc1cGRHbGhkR1ZrSUdadmNpQkNUQ0IzYVhSb0lITjBZV0pzWldOdmFXNGdjM1Z3Y0c5eWRMQWlRekVaRkVReEdFU0FRUlVmZkhVQU8wSk1JR052YlhCc2FXRnVZMlVnZG1WeWFXWnBaV1E2SUhaTVJVa2dLeUJFUTFOQklETXVNQ0IyWVd4cFpHRjBhVzl1SUdOdmJYQnNaWFJsc0NKRE1Sa1VSREVZUkRZYUFSYzJHZ0lYTmhvREY0Z0JuQllvVEZDd0lrTXhHUlJFTVJoRWdENFZIM3gxQURoQ1RDQm1jbUZqZEdsdmJtRnNhWHBsWkNCM2FYUm9JSE5vWVhKbGN5QmhkbUZwYkdGaWJHVWdabTl5SUUxVFRVVWdkSEpoWkdsdVo3QWlRekVaRkVReEdFU0FUaFVmZkhVQVNFVnVhR0Z1WTJWa0lFWnBia0pNT2lCQlpIWmhibU5sWkNCbWFXNWhibU5wWVd3Z2FXNW1ieUIzYVhSb0lHWnlZV04wYVc5dVlXeHBlbUYwYVc5dUlHRjJZV2xzWVdKc1piQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhOaG9ERnpZYUJCYzJHZ1VYTmhvR0Z6WWFCMWNDQURZYUNGY0NBRFlhQ1ZjQ0FEWWFDbGNDQURZYUMxY0NBRFlhREZjQ0FEWWFEUmMyR2c0WE5ob1BWd0lBaUFCV0ZpaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lBQmxKRlJaWEJnSk1VQ2hNVUxBaVF6RVpRUHdrTVJnVVJDSkRpZ0VCZ0IxSVpXeHNieUJtY205dElFWnBia0pNVmpJZ1JXNW9ZVzVqWldRc0lJdi9VSW1LRHdFaktXVkZBVUFBQXlralp5TXFaVVVCUUFBREtpTm5JeXRsUlFGQUFBTXJJMmNqS1dWRUlnZ3BUR2NqS1dWRUl5cGxSSXZ5Q0NwTVp5TXJaVVFpQ0N0TVo0bUtBd0dML29FVUNvbUtBUUdBQmtacGJrSk1JSXYvVUlBak9pQkZibWhoYm1ObFpDQm1hVzVoYm1OcFlXd2dhVzVtYnlCaGRtRnBiR0ZpYkdWUWlZb0NBU2NFaS81UWdCMGdaVzVvWVc1alpXUWdZMjl0Y0d4cFlXNWpaU0IyWlhKcFptbGxaRkNKaWdJQkp3U0wvbENBSWlCbGJtaGhibU5sWkNCMGIydGxibWw2WVhScGIyNGdabTl5SUhSeVlXUnBibWRRaVlvQ0FZdi9nUkVLaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
