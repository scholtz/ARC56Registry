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

namespace Arc56.Generated.bwmx.asset_staking.Managable_b1769ebb
{


    //
    // Manageable contract, designed to be inherited by other contracts (address will always be set to app creator initially)
    //
    public class ManagableProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ManagableProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Update the manager of this contract
        ///</summary>
        /// <param name="newManager"> </param>
        public async Task UpdateManager(Algorand.Address newManager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 96, 22, 142 };
            var newManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newManagerAbi.From(newManager);

            var result = await base.CallApp(new List<object> { abiHandle, newManagerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateManager_Transactions(Algorand.Address newManager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 96, 22, 142 };
            var newManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newManagerAbi.From(newManager);

            return await base.MakeTransactionList(new List<object> { abiHandle, newManagerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the manager of this contract
        ///</summary>
        public async Task DeleteManager(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 141, 66, 108 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteManager_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 141, 66, 108 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Convenience function to get the current manager of this contract
        ///</summary>
        public async Task<Algorand.Address> Manager(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 67, 64, 49 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Manager_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 67, 64, 49 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFuYWdhYmxlIiwiZGVzYyI6Ik1hbmFnZWFibGUgY29udHJhY3QsIGRlc2lnbmVkIHRvIGJlIGluaGVyaXRlZCBieSBvdGhlciBjb250cmFjdHMgKGFkZHJlc3Mgd2lsbCBhbHdheXMgYmUgc2V0IHRvIGFwcCBjcmVhdG9yIGluaXRpYWxseSkiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidXBkYXRlTWFuYWdlciIsImRlc2MiOiJVcGRhdGUgdGhlIG1hbmFnZXIgb2YgdGhpcyBjb250cmFjdCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3TWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVNYW5hZ2VyIiwiZGVzYyI6IkRlbGV0ZSB0aGUgbWFuYWdlciBvZiB0aGlzIGNvbnRyYWN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hbmFnZXIiLCJkZXNjIjoiQ29udmVuaWVuY2UgZnVuY3Rpb24gdG8gZ2V0IHRoZSBjdXJyZW50IG1hbmFnZXIgb2YgdGhpcyBjb250cmFjdCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgbWFuYWdlciBvZiB0aGlzIGNvbnRyYWN0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYyLDgzLDk1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUsODYsOThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxLDE1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOF0sImVycm9yTWVzc2FnZSI6Im1hbmFnZXIgY2Fubm90IGJlIHRoZSB6ZXJvIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBtYW5hZ2VyIGNhbiBjYWxsIHRoaXMgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p0WVc1aFoyVnlJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR3RsZVRvZ0oyMWhibUZuWlhJbkxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRnVZV2RsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXpkR0ZyYVc1bkwyMWhibUZuWVdKc1pTNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnBibWwwYVdGc1ZtRnNkV1U2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOektTd0tJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZNVEV0TVRRS0lDQWdJQzh2SUhCeWFYWmhkR1VnWDIxaGJtRm5aWElnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGtGa1pISmxjM00rS0hzS0lDQWdJQzh2SUNBZ2EyVjVPaUFuYldGdVlXZGxjaWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dibVYzSUdGeVl6UXVRV1JrY21WemN5aEhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01wTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5emRHRnJhVzVuTDIxaGJtRm5ZV0pzWlM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV0Z1WVdkaFlteGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T0RrMk1ERTJPR1VnTUhoa05EaGtOREkyWXlBd2VEWTNORE0wTURNeElDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFRXRnVZV2RsY2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpVMWhibUZuWlhJb0tYWnZhV1FpTENCdFpYUm9iMlFnSW0xaGJtRm5aWElvS1dGa1pISmxjM01pQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z3WkdGMFpVMWhibUZuWlhKZmNtOTFkR1ZBTlNCdFlXbHVYMlJsYkdWMFpVMWhibUZuWlhKZmNtOTFkR1ZBTmlCdFlXbHVYMjFoYm1GblpYSmZjbTkxZEdWQU53b0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgzTjBZV3RwYm1jdmJXRnVZV2RoWW14bExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOWVc1aFoyRmliR1VnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjFoYm1GblpYSmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjl6ZEdGcmFXNW5MMjFoYm1GbllXSnNaUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUcxaGJtRm5aWElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaV3hsZEdWTllXNWhaMlZ5WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmMzUmhhMmx1Wnk5dFlXNWhaMkZpYkdVdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbGJHVjBaVTFoYm1GblpYSW9LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWkdWc1pYUmxUV0Z1WVdkbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZOWVc1aFoyVnlYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYzNSaGEybHVaeTl0WVc1aFoyRmliR1V1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpVMWhibUZuWlhJb2JtVjNUV0Z1WVdkbGNqb2dZWEpqTkM1QlpHUnlaWE56S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5emRHRnJhVzVuTDIxaGJtRm5ZV0pzWlM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUV0Z1WVdkaFlteGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDNOMFlXdHBibWN2YldGdVlXZGhZbXhsTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVk5ZVzVoWjJWeUtHNWxkMDFoYm1GblpYSTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQjFjR1JoZEdWTllXNWhaMlZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjl6ZEdGcmFXNW5MMjFoYm1GbllXSnNaUzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RXRnVZV2RoWW14bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYzNSaGEybHVaeTl0WVc1aFoyRmliR1V1WVd4bmJ5NTBjem82VFdGdVlXZGhZbXhsTG05dWJIbE5ZVzVoWjJWeUtDa2dMVDRnZG05cFpEb0tiMjVzZVUxaGJtRm5aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmMzUmhhMmx1Wnk5dFlXNWhaMkZpYkdVdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2EyVjVPaUFuYldGdVlXZGxjaWNzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliV0Z1WVdkbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZjM1JoYTJsdVp5OXRZVzVoWjJGaWJHVXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WDIxaGJtRm5aWEl1ZG1Gc2RXVXVibUYwYVhabElEMDlQU0JVZUc0dWMyVnVaR1Z5TENBbmIyNXNlU0IwYUdVZ2JXRnVZV2RsY2lCallXNGdZMkZzYkNCMGFHbHpJRzFsZEdodlpDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ2RHaGxJRzFoYm1GblpYSWdZMkZ1SUdOaGJHd2dkR2hwY3lCdFpYUm9iMlFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5emRHRnJhVzVuTDIxaGJtRm5ZV0pzWlM1aGJHZHZMblJ6T2pwTllXNWhaMkZpYkdVdWRYQmtZWFJsVFdGdVlXZGxjaWh1WlhkTllXNWhaMlZ5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxUV0Z1WVdkbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjl6ZEdGcmFXNW5MMjFoYm1GbllXSnNaUzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWEJrWVhSbFRXRnVZV2RsY2lodVpYZE5ZVzVoWjJWeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTFoYm1GblpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGROWVc1aFoyVnlMbTVoZEdsMlpTQWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENBbmJXRnVZV2RsY2lCallXNXViM1FnWW1VZ2RHaGxJSHBsY204Z1lXUmtjbVZ6Y3ljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFlXNWhaMlZ5SUdOaGJtNXZkQ0JpWlNCMGFHVWdlbVZ5YnlCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmMzUmhhMmx1Wnk5dFlXNWhaMkZpYkdVdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2EyVjVPaUFuYldGdVlXZGxjaWNzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDNOMFlXdHBibWN2YldGdVlXZGhZbXhsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSb2FYTXVYMjFoYm1GblpYSXVkbUZzZFdVZ1BTQnVaWGROWVc1aFoyVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYzNSaGEybHVaeTl0WVc1aFoyRmliR1V1WVd4bmJ5NTBjem82VFdGdVlXZGhZbXhsTG1SbGJHVjBaVTFoYm1GblpYSW9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVk5ZVzVoWjJWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTFoYm1GblpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYM04wWVd0cGJtY3ZiV0Z1WVdkaFlteGxMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR3RsZVRvZ0oyMWhibUZuWlhJbkxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRnVZV2RsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXpkR0ZyYVc1bkwyMWhibUZuWVdKc1pTNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QjBhR2x6TGw5dFlXNWhaMlZ5TG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01wQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYzNSaGEybHVaeTl0WVc1aFoyRmliR1V1WVd4bmJ5NTBjem82VFdGdVlXZGhZbXhsTG0xaGJtRm5aWElvS1NBdFBpQmllWFJsY3pvS2JXRnVZV2RsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXpkR0ZyYVc1bkwyMWhibUZuWVdKc1pTNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnJaWGs2SUNkdFlXNWhaMlZ5Snl3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjl6ZEdGcmFXNW5MMjFoYm1GbllXSnNaUzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZmJXRnVZV2RsY2k1MllXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BUWR0WVc1aFoyVnlNUmhBQUFRb01nbG5NUnRCQUU2Q0F3U0pZQmFPQk5TTlFtd0VaME5BTVRZYUFJNERBQ01BRndBQ0kwTXhHUlJFTVJoRWlBQlRnQVFWSDN4MVRGQ3dJa014R1JSRU1SaEVpQUEySWtNeEdSUkVNUmhFTmhvQmlBQVdJa014R1VEL3lURVlGRVFpUXlNb1pVUXhBQkpFaVlvQkFJai84WXYvTWdNVFJDaUwvMmVKaVAvaktESURaNGtqS0dWRWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
