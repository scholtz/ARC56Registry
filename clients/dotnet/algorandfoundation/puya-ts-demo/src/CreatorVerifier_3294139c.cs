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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.CreatorVerifier_3294139c
{


    public class CreatorVerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreatorVerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow anyone to use the lsig to opt in the txn sender into an asset created by the creator
        ///</summary>
        /// <param name="creator"> </param>
        public async Task AllowOptInsFrom(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 191, 44, 168 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            var result = await base.CallApp(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AllowOptInsFrom_Transactions(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 191, 44, 168 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Disable opt-ins for ASAs from the given creator
        ///</summary>
        /// <param name="creator"> </param>
        public async Task DisableOptInsFrom(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 40, 172, 43 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            var result = await base.CallApp(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DisableOptInsFrom_Transactions(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 40, 172, 43 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="optIn"> </param>
        public async Task VerifyCreator(AssetTransferTransaction optIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { optIn });
            byte[] abiHandle = { 141, 90, 167, 39 };

            var result = await base.CallApp(new List<object> { abiHandle, optIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyCreator_Transactions(AssetTransferTransaction optIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { optIn });
            byte[] abiHandle = { 141, 90, 167, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle, optIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlYXRvclZlcmlmaWVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFsbG93T3B0SW5zRnJvbSIsImRlc2MiOiJBbGxvdyBhbnlvbmUgdG8gdXNlIHRoZSBsc2lnIHRvIG9wdCBpbiB0aGUgdHhuIHNlbmRlciBpbnRvIGFuIGFzc2V0IGNyZWF0ZWQgYnkgdGhlIGNyZWF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGlzYWJsZU9wdEluc0Zyb20iLCJkZXNjIjoiRGlzYWJsZSBvcHQtaW5zIGZvciBBU0FzIGZyb20gdGhlIGdpdmVuIGNyZWF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5Q3JlYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTA0XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTJdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnh6YVdjdGQybDBhQzFoY0hBdmJITnBaeTEzYVhSb0xXRndjQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EzSmxZWFJ2Y2xabGNtbG1hV1Z5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhtTVdKbU1tTmhPQ0F3ZUdKak1qaGhZekppSURCNE9HUTFZV0UzTWpjZ0x5OGdiV1YwYUc5a0lDSmhiR3h2ZDA5d2RFbHVjMFp5YjIwb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0prYVhOaFlteGxUM0IwU1c1elJuSnZiU2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVVOeVpXRjBiM0lvWVhobVpYSXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHRnNiRzkzVDNCMFNXNXpSbkp2YlNCa2FYTmhZbXhsVDNCMFNXNXpSbkp2YlNCMlpYSnBabmxEY21WaGRHOXlDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFOem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFTnlaV0YwYjNKV1pYSnBabWxsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFEZ0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUE0T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ4emFXY3RkMmwwYUMxaGNIQXZiSE5wWnkxM2FYUm9MV0Z3Y0M1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ0p5WlhGMWFYSmxJaUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem82UTNKbFlYUnZjbFpsY21sbWFXVnlMbUZzYkc5M1QzQjBTVzV6Um5KdmJWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZzYkc5M1QzQjBTVzV6Um5KdmJUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXNjMmxuTFhkcGRHZ3RZWEJ3TDJ4emFXY3RkMmwwYUMxaGNIQXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkR2hwY3k1aGJHeHZkMlZrUTNKbFlYUnZjbk1vVzFSNGJpNXpaVzVrWlhJc0lHTnlaV0YwYjNJdWJtRjBhWFpsWFNrdWRtRnNkV1VnUFNCdVpYY2dRbTl2YkNoMGNuVmxLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXNjMmxuTFhkcGRHZ3RZWEJ3TDJ4emFXY3RkMmwwYUMxaGNIQXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdZV3hzYjNkUGNIUkpibk5HY205dEtHTnlaV0YwYjNJNklFRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5c2MybG5MWGRwZEdndFlYQndMMnh6YVdjdGQybDBhQzFoY0hBdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RHaHBjeTVoYkd4dmQyVmtRM0psWVhSdmNuTW9XMVI0Ymk1elpXNWtaWElzSUdOeVpXRjBiM0l1Ym1GMGFYWmxYU2t1ZG1Gc2RXVWdQU0J1WlhjZ1FtOXZiQ2gwY25WbEtUc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5c2MybG5MWGRwZEdndFlYQndMMnh6YVdjdGQybDBhQzFoY0hBdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1lXeHNiM2RQY0hSSmJuTkdjbTl0S0dOeVpXRjBiM0k2SUVGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZiSE5wWnkxM2FYUm9MV0Z3Y0M5c2MybG5MWGRwZEdndFlYQndMbUZzWjI4dWRITTZPa055WldGMGIzSldaWEpwWm1sbGNpNWthWE5oWW14bFQzQjBTVzV6Um5KdmJWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJwYzJGaWJHVlBjSFJKYm5OR2NtOXRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnh6YVdjdGQybDBhQzFoY0hBdmJITnBaeTEzYVhSb0xXRndjQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUIwYUdsekxtRnNiRzkzWldSRGNtVmhkRzl5Y3loYlZIaHVMbk5sYm1SbGNpd2dZM0psWVhSdmNpNXVZWFJwZG1WZEtTNTJZV3gxWlNBOUlHNWxkeUJDYjI5c0tHWmhiSE5sS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWkdsellXSnNaVTl3ZEVsdWMwWnliMjBvWTNKbFlYUnZjam9nUVdSa2NtVnpjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnh6YVdjdGQybDBhQzFoY0hBdmJITnBaeTEzYVhSb0xXRndjQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUIwYUdsekxtRnNiRzkzWldSRGNtVmhkRzl5Y3loYlZIaHVMbk5sYm1SbGNpd2dZM0psWVhSdmNpNXVZWFJwZG1WZEtTNTJZV3gxWlNBOUlHNWxkeUJDYjI5c0tHWmhiSE5sS1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWkdsellXSnNaVTl3ZEVsdWMwWnliMjBvWTNKbFlYUnZjam9nUVdSa2NtVnpjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXNjMmxuTFhkcGRHZ3RZWEJ3TDJ4emFXY3RkMmwwYUMxaGNIQXVZV3huYnk1MGN6bzZRM0psWVhSdmNsWmxjbWxtYVdWeUxuWmxjbWxtZVVOeVpXRjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxEY21WaGRHOXlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnh6YVdjdGQybDBhQzFoY0hBdmJITnBaeTEzYVhSb0xXRndjQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUIyWlhKcFpubERjbVZoZEc5eUtHOXdkRWx1T2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnZEdocGN5NWhiR3h2ZDJWa1EzSmxZWFJ2Y25Nb1cyOXdkRWx1TG5ObGJtUmxjaXdnYjNCMFNXNHVlR1psY2tGemMyVjBMbU55WldGMGIzSmRLUzUyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnlaV0YwYjNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXNjMmxuTFhkcGRHZ3RZWEJ3TDJ4emFXY3RkMmwwYUMxaGNIQXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdMbTVoZEdsMlpTd0tJQ0FnSUhCMWMyaHBiblFnTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlzYzJsbkxYZHBkR2d0WVhCd0wyeHphV2N0ZDJsMGFDMWhjSEF1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnZG1WeWFXWjVRM0psWVhSdmNpaHZjSFJKYmpvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVLVG9nZG05cFpDQjdDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVRFWkZFUXhHRUVBSFlJREJQRy9MS2dFdkNpc0t3U05XcWNuTmhvQWpnTUFFUUFkQUNrQWdBUzRSSHMyTmhvQWpnRUFBUUFpUXpFQU5ob0JVSUFCZ0w4aVF6RUFOaG9CVUlBQkFMOGlRekVXSWdsSk9CQ0JCQkpFU1RnQVREZ1JjUXRFVUw1RWdRQlRRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
