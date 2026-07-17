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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_01f19ef2
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_a"> </param>
        /// <param name="__arc4_b"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> F(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 144, 130, 255 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_a, __arc4_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> F_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 144, 130, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_a, __arc4_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> G(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 223, 135, 213 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.SimApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> G_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 223, 135, 213 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_a"> </param>
        /// <param name="__arc4_b"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> H(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 105, 250, 223 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_a, __arc4_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> H_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 105, 250, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_a, __arc4_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9iIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM2LDI1NF0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1XSwiZXJyb3JNZXNzYWdlIjoiZGl2aXNpb24gYnkgemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNywxNDcsNzA1LDcxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTEsMjAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwLDIxOCw3MjhdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MCw1NDEsNzM4XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTBdLCJlcnJvck1lc3NhZ2UiOiJzaWduZWQgZGl2aXNpb24gb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmRtbGhXWFZzTDJSbGRHVmpkRjlrYVhaZmIzWmxjbVpzYjNjdWMyOXNMa011WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURBZ09DQXhPRFEwTmpjME5EQTNNemN3T1RVMU1UUTRPQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREF4TURBZ01IZ2dNSGc0TUNBd2VERTFNV1kzWXpjMUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaSFZ3YmlBeE1Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBaUlnb2dJQ0FnWkhWd2JpQTBDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNbUk1TURneVptWWdNSGhtWW1SbU9EZGtOU0F3ZURWak5qbG1ZV1JtSUM4dklHMWxkR2h2WkNBaVppaDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVp5aDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1nb2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMlpmY205MWRHVkFOU0J0WVdsdVgyZGZjbTkxZEdWQU5pQnRZV2x1WDJoZmNtOTFkR1ZBTndvZ0lDQWdaWEp5Q2dwdFlXbHVYMmhmY205MWRHVkFOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4T0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdZaThLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRRS0NtMWhhVzVmWjE5eWIzVjBaVUEyT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UZ0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UazZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJREV5TndvZ0lDQWdQRDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnZiMnhmZEhKMVpVQXlNUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR01nTkNBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UUTRPQW9nSUNBZ1BqMEtJQ0FnSUdKNklHMWhhVzVmWW05dmJGOW1ZV3h6WlVBeU1nb0tiV0ZwYmw5aWIyOXNYM1J5ZFdWQU1qRTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tiV0ZwYmw5aWIyOXNYMjFsY21kbFFESXpPZ29nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXhNamNLSUNBZ0lEdzlDaUFnSUNCaWJub2diV0ZwYmw5aWIyOXNYM1J5ZFdWQU1qVUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJRFFnTHk4Z01UZzBORFkzTkRRd056TTNNRGsxTlRFME9EZ0tJQ0FnSUQ0OUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBTWpZS0NtMWhhVzVmWW05dmJGOTBjblZsUURJMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtMWhhVzVmWW05dmJGOXRaWEpuWlVBeU56b0tJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZWE56WlhKMElDOHZJR1JwZG1semFXOXVJR0o1SUhwbGNtOEtJQ0FnSUdScFp5QTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TUFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TUFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURnd0NpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGFXNWZZbTl2YkY5bVlXeHpaVUF6TUFvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdabUNpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGFXNWZZbTl2YkY5bVlXeHpaVUF6TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ20xaGFXNWZZbTl2YkY5dFpYSm5aVUF6TVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnphV2R1WldRZ1pHbDJhWE5wYjI0Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEZ3dDaUFnSUNCaVBBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUUtJQ0FnSUNFS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdJOENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnSVFvZ0lDQWdJVDBLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TUFvZ0lDQWdaR2xuSURrS0lDQWdJR0l0Q2lBZ0lDQmlkWEo1SURFekNncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNelU2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTU2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek53b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmlMUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNNE9nb2dJQ0FnWkdsbklERXpDaUFnSUNCemQyRndDaUFnSUNCaUx3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUTJDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdScFp5QTVDaUFnSUNCaUxRb2dJQ0FnWW5WeWVTQXhNZ29LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURReU9nb2dJQ0FnWkdsbklERUtJQ0FnSUdKdWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFORFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOVG9LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVE02Q2lBZ0lDQmthV2NnT0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdSMWNBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWTRDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdScFp5QTVDaUFnSUNCaUxRb2dJQ0FnWW5WeWVTQXhNQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVM09nb2dJQ0FnWkdsbklERUtJQ0FnSUdKdWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVGtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJNRG9LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT0FvZ0lDQWdaR2xuSURJS0lDQWdJR0p1ZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmthV2NnT1FvZ0lDQWdZaTBLSUNBZ0lHSjFjbmtnTVRVS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJORG9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHSXRDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpjNkNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmlKUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjMU9nb2dJQ0FnWkdsbklEZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaR2xuSURjS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWUtJQ0FnSUdJbUNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnNE1Bb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU56Y0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQUtJQ0FnSUdJckNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOemc2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjM09nb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU56Z0tDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTmpvS0lDQWdJR1JwWnlBMUNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk53b0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFl6T2dvZ0lDQWdaR2xuSURnS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWTBDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpnNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBS0lDQWdJR1JwWnlBNUNpQWdJQ0JpTFFvZ0lDQWdZblZ5ZVNBeE5Bb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGN4T2dvZ0lDQWdaR2xuSURFS0lDQWdJR0p1ZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU56TUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZaTBLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBM05Eb0tJQ0FnSUdScFp5QXhOQW9nSUNBZ2MzZGhjQW9nSUNBZ1lpOEtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEYzFDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTnpNNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU56UUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEzTURvS0lDQWdJR1JwWnlBNENpQWdJQ0JpZFhKNUlERTBDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVNU9nb2dJQ0FnWkdsbklEVUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWXdDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTlRZNkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVGNLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Eb0tJQ0FnSUdScFp5QTFDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURReE9nb2dJQ0FnWkdsbklEZ0tJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFF5Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5EWTZDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdScFp5QTVDaUFnSUNCaUxRb2dJQ0FnWW5WeWVTQXhNUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRNU9nb2dJQ0FnWkdsbklERUtJQ0FnSUdKdWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVEVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFNam9LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFV6Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5URTZDaUFnSUNCa2FXY2dOUW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVElLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Eb0tJQ0FnSUdScFp5QTRDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT1FvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTNPZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE00Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16UTZDaUFnSUNCa2FXY2dPQW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpVS0NtMWhhVzVmWW05dmJGOW1ZV3h6WlVBek1Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZZbTl2YkY5dFpYSm5aVUF6TVFvS2JXRnBibDlpYjI5c1gyWmhiSE5sUURJMk9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOWliMjlzWDIxbGNtZGxRREkzQ2dwdFlXbHVYMkp2YjJ4ZlptRnNjMlZBTWpJNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgySnZiMnhmYldWeVoyVkFNak1LQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9Rb0tiV0ZwYmw5bVgzSnZkWFJsUURVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdJdkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZ3lPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEZ3pDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZkbWxoV1hWc0wyUmxkR1ZqZEY5a2FYWmZiM1psY21ac2IzY3VjMjlzTGtNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQVNBQUNJRC8vLy8vLy8vLy93RW1CQUlCQUFBQmdBUVZIM3gxSkVjTEtVY0VnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUNJa014R1JSRU1SaEVnZ01FSzVDQy93VDczNGZWQkZ4cCt0ODJHZ0NPQXdJNUFEa0FBUUEyR2dGSlJSSVZJeEpFTmhvQ1NVVVJGU01TUkRFV1FRQWJNUllpQ1RnSUZFUkxFRXNRb2trVkl3NUVJNitySzB4UXNDSkRKRUwvNXpZYUFVa1ZKUkpFRjBVRk5ob0NTUlVsRWtRWFJRUXhGa0VCNFRFV0lnazRDQlJFU3dTQmZ3NUFBQWhMQkNFRUQwRUJ4U0pFU3dPQmZ3NUFBQWhMQXlFRUQwRUJyeUpFU3dNV0tLcEpSUWNwcVVSTEJCWW9xa2xGQ2lxb1FRR1JTd1dBQWYrb1FRR0lJaFJFSmE5RkNFc0lLcVJKUlFRVVN3WXFwRWxGQkJRVFNVVUNRUUUzU3dKQUFWNG9Td21oUlExTEFVQUJUaWhMQnFGTERVeWlLYWhBQVJwTEFrQUJEaWhMQ2FGRkRFc0JRQUQrS0VzR29Vc01US0lvVEtFb3Frc0lURkJGQjBsQkFMUkxBa0FBMnloTENhRkZDa3NCUUFETEtFc0dvVXNLVEtJcHFFQUFsMHNDUUFDTEtFc0pvVVVQU3dGQUFIc29Td2FoU3c5TW9paE1vU2lxU3doTVVCVWxDVXNIVENWWWdBSC9yRWtxcDBFQVZZQWcvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL3dDZ2dDRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDcVNSVWpEa1FqcjZzclRGQ3dJa05DLys5TEJVTC9oRXNJUlE5Qy8zUkxBa0FBR3loTENhRkZEa3NCUUFBTEtFc0dvVXNPVEtKQy8ydExCVUwvOUVzSVJRNUMvK1JMQlVML05Fc0lSUXBDL3lSTEJVTC9BVXNJUlF4Qy92RkxBa0FBR3loTENhRkZDMHNCUUFBTEtFc0dvVXNMVEtKQy91aExCVUwvOUVzSVJRdEMvK1JMQlVMK3NVc0lSUTFDL3FFa1F2NTFKRUwrVGlSQy9qZ2tRdjRoTmhvQlNVVVNGU01TUkRZYUFrbEZFUlVqRWtReEZrRUFHekVXSWdrNENCUkVTeEJMRUtKSkZTTU9SQ092cXl0TVVMQWlReVJDLytjPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
