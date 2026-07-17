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

namespace Arc56.Generated.Potti1234.PottiSwap.Resolver_e87aaede
{


    public class ResolverProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ResolverProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="factoryAppId">App ID of the factory contract </param>
        public async Task CreateResolver(ulong factoryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 131, 164, 252 };
            var factoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAppIdAbi.From(factoryAppId);

            var result = await base.CallApp(new List<object> { abiHandle, factoryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateResolver_Transactions(ulong factoryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 131, 164, 252 };
            var factoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAppIdAbi.From(factoryAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, factoryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="timelock"> </param>
        /// <param name="secretHash"> </param>
        /// <param name="taker"> </param>
        public async Task<ulong> DeployEscrow(ulong timelock, byte[] secretHash, Algorand.Address taker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 130, 144, 50 };
            var timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timelockAbi.From(timelock);
            var secretHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretHashAbi.From(secretHash);
            var takerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); takerAbi.From(taker);

            var result = await base.CallApp(new List<object> { abiHandle, timelockAbi, secretHashAbi, takerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeployEscrow_Transactions(ulong timelock, byte[] secretHash, Algorand.Address taker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 130, 144, 50 };
            var timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timelockAbi.From(timelock);
            var secretHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretHashAbi.From(secretHash);
            var takerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); takerAbi.From(taker);

            return await base.MakeTransactionList(new List<object> { abiHandle, timelockAbi, secretHashAbi, takerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="secret"> </param>
        public async Task ClaimEscrow(byte[] secret, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 92, 209, 120 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);

            var result = await base.CallApp(new List<object> { abiHandle, secretAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimEscrow_Transactions(byte[] secret, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 92, 209, 120 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);

            return await base.MakeTransactionList(new List<object> { abiHandle, secretAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVzb2x2ZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlUmVzb2x2ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmFjdG9yeUFwcElkIiwiZGVzYyI6IkFwcCBJRCBvZiB0aGUgZmFjdG9yeSBjb250cmFjdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBsb3lFc2Nyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZWxvY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VjcmV0SGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRha2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1Fc2Nyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWNyZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1OSw3NCwxMDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Miw3NywxMDldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwLDIwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZS0lDQWdJR0o1ZEdWallteHZZMnNnSW1aaFkzUnZjbmxCY0hCSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pYTnZiSFpsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBNENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1UWTRNMkUwWm1NZ01IZzJNVGd5T1RBek1pQXdlR0ZqTldOa01UYzRJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxVbVZ6YjJ4MlpYSW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGNHeHZlVVZ6WTNKdmR5aDFhVzUwTmpRc1lubDBaVnN6TWwwc1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Oc1lXbHRSWE5qY205M0tHSjVkR1ZiTXpKZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWSmxjMjlzZG1WeVgzSnZkWFJsUURNZ2JXRnBibDlrWlhCc2IzbEZjMk55YjNkZmNtOTFkR1ZBTkNCdFlXbHVYMk5zWVdsdFJYTmpjbTkzWDNKdmRYUmxRRFVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pYTnZiSFpsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJ4aGFXMUZjMk55YjNkZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJTWlhOdmJIWmxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHTnNZV2x0UlhOamNtOTNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxjR3h2ZVVWelkzSnZkMTl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012Y21WemIyeDJaWEl1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012Y21WemIyeDJaWEl1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGSmxjMjlzZG1WeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZjbVZ6YjJ4MlpYSXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWkdWd2JHOTVSWE5qY205M0NpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxVbVZ6YjJ4MlpYSmZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pYTnZiSFpsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWSmxjMjlzZG1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012Y21WemIyeDJaWEl1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGSmxjMjlzZG1WeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTl5WlhOdmJIWmxjaTVoYkdkdkxuUnpPanBTWlhOdmJIWmxjaTVqY21WaGRHVlNaWE52YkhabGNpaG1ZV04wYjNKNVFYQndTV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxVbVZ6YjJ4MlpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTl5WlhOdmJIWmxjaTVoYkdkdkxuUnpPakkxTFRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR055WldGMFpWSmxjMjlzZG1WeUtHWmhZM1J2Y25sQmNIQkpaRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCbVlXTjBiM0o1UVhCd1NXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbVlXTjBiM0o1UVhCd1NXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTl5WlhOdmJIWmxjaTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUIwYUdsekxtWmhZM1J2Y25sQmNIQkpaQzUyWVd4MVpTQTlJR1poWTNSdmNubEJjSEJKWkRzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk9sSmxjMjlzZG1WeUxtUmxjR3h2ZVVWelkzSnZkeWgwYVcxbGJHOWphem9nZFdsdWREWTBMQ0J6WldOeVpYUklZWE5vT2lCaWVYUmxjeXdnZEdGclpYSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbVJsY0d4dmVVVnpZM0p2ZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk16QXRNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1pHVndiRzk1UlhOamNtOTNLSFJwYldWc2IyTnJPaUIxYVc1ME5qUXNJSE5sWTNKbGRFaGhjMmc2SUdGeVl6UXVVM1JoZEdsalFubDBaWE04TXpJK0xDQjBZV3RsY2pvZ1FXUmtjbVZ6Y3lrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdOdmJuTjBJR1JsY0c5emFYUWdQU0JuZEhodUxsQmhlVzFsYm5SVWVHNG9NQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJtWVdOMGIzSjVRWEJ3U1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlabUZqZEc5eWVVRndjRWxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TXpVdE5ERUtJQ0FnSUM4dklHTnZibk4wSUdWelkzSnZkMEZ3Y0Vsa0lEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ1ptRmpkRzl5ZVVGd2NFbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0MGFXMWxiRzlqYXl3Z2MyVmpjbVYwU0dGemFDd2dkR0ZyWlhKZExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ1IyeHZZbUZzTG0xcGJsUjRia1psWlN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZjbVZ6YjJ4MlpYSXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdabVZsT2lCSGJHOWlZV3d1YldsdVZIaHVSbVZsTEFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZjbVZ6YjJ4MlpYSXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdZWEJ3UVhKbmN6b2dXM1JwYldWc2IyTnJMQ0J6WldOeVpYUklZWE5vTENCMFlXdGxjbDBzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBiMklLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzSmxjMjlzZG1WeUxtRnNaMjh1ZEhNNk16VXROREFLSUNBZ0lDOHZJR052Ym5OMElHVnpZM0p2ZDBGd2NFbGtJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCSlpEb2dabUZqZEc5eWVVRndjRWxrTEFvZ0lDQWdMeThnSUNBZ0lHRndjRUZ5WjNNNklGdDBhVzFsYkc5amF5d2djMlZqY21WMFNHRnphQ3dnZEdGclpYSmRMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dSMnh2WW1Gc0xtMXBibFI0YmtabFpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZjbVZ6YjJ4MlpYSXVZV3huYnk1MGN6b3pOUzAwTVFvZ0lDQWdMeThnWTI5dWMzUWdaWE5qY205M1FYQndTV1FnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NFbGtPaUJtWVdOMGIzSjVRWEJ3U1dRc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXM1JwYldWc2IyTnJMQ0J6WldOeVpYUklZWE5vTENCMFlXdGxjbDBzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUJIYkc5aVlXd3ViV2x1VkhodVJtVmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTl5WlhOdmJIWmxjaTVoYkdkdkxuUnpPalEwTFRVd0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdSbGNHOXphWFF1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCbGMyTnliM2RCY0hCSlpDNWhZMk52ZFc1MGN5Z3dLU3dLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5eVpYTnZiSFpsY2k1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCamIyNXpkQ0JrWlhCdmMybDBJRDBnWjNSNGJpNVFZWGx0Wlc1MFZIaHVLREFwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdGdGIzVnVkRG9nWkdWd2IzTnBkQzVoYlc5MWJuUXNDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJsYzJOeWIzZEJjSEJKWkM1aFkyTnZkVzUwY3lnd0tTd0tJQ0FnSUdsMGVHNWhJRUZqWTI5MWJuUnpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhObGJtUmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OXlaWE52YkhabGNpNWhiR2R2TG5Sek9qUTBMVFE1Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR1JsY0c5emFYUXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJsYzJOeWIzZEJjSEJKWkM1aFkyTnZkVzUwY3lnd0tTd0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmNtVnpiMngyWlhJdVlXeG5ieTUwY3pvME5DMDFNQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmtaWEJ2YzJsMExtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2daWE5qY205M1FYQndTV1F1WVdOamIzVnVkSE1vTUNrc0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmxjMk55YjNkQmNIQkpaQzVoY0hCSlpDNXBaRHNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNKbGMyOXNkbVZ5TG1Gc1oyOHVkSE02T2xKbGMyOXNkbVZ5TG1Oc1lXbHRSWE5qY205M0tITmxZM0psZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21Oc1lXbHRSWE5qY205M09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZjbVZ6YjJ4MlpYSXVZV3huYnk1MGN6bzFOUzAxTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QmpiR0ZwYlVWelkzSnZkeWh6WldOeVpYUTZJR0Z5WXpRdVUzUmhkR2xqUW5sMFpYTThNekkrS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5Qm1ZV04wYjNKNVFYQndTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVptRmpkRzl5ZVVGd2NFbGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZOVGt0TmpVS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJR1poWTNSdmNubEJjSEJKWkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJjMlZqY21WMFhTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklFZHNiMkpoYkM1dGFXNVVlRzVHWldVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM0psYzI5c2RtVnlMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR1psWlRvZ1IyeHZZbUZzTG0xcGJsUjRia1psWlN3S0lDQWdJR2RzYjJKaGJDQk5hVzVVZUc1R1pXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmNtVnpiMngyWlhJdVlXeG5ieTUwY3pvMU9TMDJOQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJKWkRvZ1ptRmpkRzl5ZVVGd2NFbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0elpXTnlaWFJkTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nUjJ4dlltRnNMbTFwYmxSNGJrWmxaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012Y21WemIyeDJaWEl1WVd4bmJ5NTBjem8xT1MwMk5Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nWm1GamRHOXllVUZ3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0VGeVozTTZJRnR6WldOeVpYUmRMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dSMnh2WW1Gc0xtMXBibFI0YmtabFpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRUdKZ0VNWm1GamRHOXllVUZ3Y0Vsa01SdEJBRjJDQXdRV2c2VDhCR0dDa0RJRXJGelJlRFlhQUk0REFERUFFUUFDSWtNeEdSUkVNUmhFTmhvQmlBQ0VJME14R1JSRU1SaEVOaG9CRnpZYUFqWWFBNGdBTHhhQUJCVWZmSFZNVUxBalF6RVpGRVF4R0VRMkdnRVhpQUFOSTBNeEdVRC91akVZRkVRalE0b0JBQ2lMLzJlSmlnTUJJamdRSXhKRUlpaGxSTEV5QUl2OUZySWFpLzZ5R292L3NocE1zaGdrc2hDeUFiTzBHTEVpT0FpMUhBQXlDcklBc2dleUNDT3lFQ0t5QWJPSmlnRUFJaWhsUkxFeUFJdi9zaHBNc2hna3NoQ3lBYk9KIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
