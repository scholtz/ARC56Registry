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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_e4248d89
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
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> H(System.Numerics.BigInteger __arc4_a, System.Numerics.BigInteger __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 154, 139, 108 };
            var __arc4_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_aAbi.From(__arc4_a);
            var __arc4_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_bAbi.From(__arc4_b);

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_aAbi, __arc4_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> H_Transactions(System.Numerics.BigInteger __arc4_a, System.Numerics.BigInteger __arc4_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 154, 139, 108 };
            var __arc4_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_aAbi.From(__arc4_a);
            var __arc4_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_bAbi.From(__arc4_b);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_aAbi, __arc4_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9iIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MTYwIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNjAiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTQ3LDU2NV0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4LDI1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxNjAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTUsODA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMiw1MTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsNTI5LDgxOF0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIwLDcwNSw4ODddLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MCw2MzMsODc1XSwiZXJyb3JNZXNzYWdlIjoic2lnbmVkIGFyaXRobWV0aWMgb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmRtbGhXWFZzTDJSbGRHVmpkRjl0ZFd4ZmIzWmxjbVpzYjNkZmMybG5ibVZrTG5OdmJDNURMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15SURnZ01UZzBORFkzTkRRd056TTNNRGsxTlRFME9EZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNVEF3SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlRGd3SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlREUxTVdZM1l6YzFDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd2JpQTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREppT1RBNE1tWm1JREI0Wm1Ka1pqZzNaRFVnTUhoaU9UbGhPR0kyWXlBdkx5QnRaWFJvYjJRZ0ltWW9kV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltY29kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKb0tIVnBiblF4TmpBc2RXbHVkREUyTUNsMWFXNTBNalUySWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDltWDNKdmRYUmxRRFVnYldGcGJsOW5YM0p2ZFhSbFFEWWdiV0ZwYmw5b1gzSnZkWFJsUURjS0lDQWdJR1Z5Y2dvS2JXRnBibDlvWDNKdmRYUmxRRGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRNS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1UWXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTVRZd0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnZiMnhmZEhKMVpVQXpNUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lDRUtJQ0FnSUdScFp5QTNDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZandLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQWhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4T0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHSXRDaUFnSUNCaWRYSjVJREV3Q2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UazZDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHSXRDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpJNkNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqd0tDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TURvS0lDQWdJR0o2SUcxaGFXNWZZbTl2YkY5bVlXeHpaVUF6TWdvS2JXRnBibDlpYjI5c1gzUnlkV1ZBTXpFNkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvS2JXRnBibDlpYjI5c1gyMWxjbWRsUURNek9nb2dJQ0FnWVhOelpYSjBJQzh2SUhOcFoyNWxaQ0JoY21sMGFHMWxkR2xqSUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOd29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16VUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE0yT2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5Ub0tJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTJDZ3B0WVdsdVgySnZiMnhmWm1Gc2MyVkFNekk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDJKdmIyeGZiV1Z5WjJWQU16TUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVRvS0lDQWdJR1JwWnlBMkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1nb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU0T2dvZ0lDQWdaR2xuSURVS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpNNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlOUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWkdsbklEWUtJQ0FnSUdJdENpQWdJQ0JpZFhKNUlEa0tDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TmpvS0lDQWdJR1JwWnlBeENpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JrYVdjZ053b2dJQ0FnWWkwS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlPVG9LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpNQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNE9nb2dJQ0FnWkdsbklEWUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpVNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW5WeWVTQTVDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMENncHRZV2x1WDJkZmNtOTFkR1ZBTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEUXhPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4TWpjS0lDQWdJRHc5Q2lBZ0lDQmlibm9nYldGcGJsOWliMjlzWDNSeWRXVkFORE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTBPRGdLSUNBZ0lENDlDaUFnSUNCaWVpQnRZV2x1WDJKdmIyeGZabUZzYzJWQU5EUUtDbTFoYVc1ZlltOXZiRjkwY25WbFFEUXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbTFoYVc1ZlltOXZiRjl0WlhKblpVQTBOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNVEkzQ2lBZ0lDQThQUW9nSUNBZ1ltNTZJRzFoYVc1ZlltOXZiRjkwY25WbFFEUTNDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZeUEwSUM4dklERTRORFEyTnpRME1EY3pOekE1TlRVeE5EZzRDaUFnSUNBK1BRb2dJQ0FnWW5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURRNENncHRZV2x1WDJKdmIyeGZkSEoxWlVBME56b0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncHRZV2x1WDJKdmIyeGZiV1Z5WjJWQU5EazZDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01Bb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbTU2SUcxaGFXNWZZbTl2YkY5MGNuVmxRRFkyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEZ3dDaUFnSUNCaVBBb2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQmthV2NnTndvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURnd0NpQWdJQ0JpUEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQ0VLSUNBZ0lEMDlDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVGdLSUNBZ0lHSnVlaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTlRNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdDaUFnSUNCa2FXY2dPQW9nSUNBZ1lpMEtJQ0FnSUdKMWNua2dNVEFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU5Eb0tJQ0FnSUdSMWNBb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFOZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBS0lDQWdJR1JwWnlBMkNpQWdJQ0JpTFFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEVTNPZ29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGd3Q2lBZ0lDQmlQQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURZMU9nb2dJQ0FnWW5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURZM0NncHRZV2x1WDJKdmIyeGZkSEoxWlVBMk5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncHRZV2x1WDJKdmIyeGZiV1Z5WjJWQU5qZzZDaUFnSUNCaGMzTmxjblFnTHk4Z2MybG5ibVZrSUdGeWFYUm9iV1YwYVdNZ2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdDaUFnSUNCaUpRb2dJQ0FnWkdsbklEY0tJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERXdNQW9nSUNBZ1lpVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdabUNpQWdJQ0JpSmdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0T0RBS0lDQWdJR0krUFFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmpBd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNVG9LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTnpBNkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBM01Rb0tiV0ZwYmw5aWIyOXNYMlpoYkhObFFEWTNPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDlpYjI5c1gyMWxjbWRsUURZNENncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVFk2Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTlRjS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFNem9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU5Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFU0T2dvZ0lDQWdZbTU2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk1Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhNREFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmlMUW9nSUNBZ1luVnllU0E1Q2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qRTZDaUFnSUNCa2RYQUtJQ0FnSUdKdWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOak1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJORG9LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGd3Q2lBZ0lDQmlQZ29nSUNBZ0lRb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qVUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTXpvS0lDQWdJR1JwWnlBMUNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk5Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFl3T2dvZ0lDQWdaR2xuSURjS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qRUtDbTFoYVc1ZlltOXZiRjltWVd4elpVQTBPRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmWW05dmJGOXRaWEpuWlVBME9Rb0tiV0ZwYmw5aWIyOXNYMlpoYkhObFFEUTBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDlpYjI5c1gyMWxjbWRsUURRMUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOREE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOREVLQ20xaGFXNWZabDl5YjNWMFpVQTFPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOelVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOelk2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKdWVpQnRZV2x1WDJKdmIyeGZkSEoxWlVBNU13b2dJQ0FnWkdsbklERXhDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqd0tJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWp3S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0FoQ2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGcxQ2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCa2FXY2dNVElLSUNBZ0lHSXRDaUFnSUNCaWRYSjVJREV3Q2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9ERTZDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE0TXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWkdsbklERXhDaUFnSUNCaUxRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGcwT2dvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpS2dvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0k4Q2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9USTZDaUFnSUNCaWVpQnRZV2x1WDJKdmIyeGZabUZzYzJWQU9UUUtDbTFoYVc1ZlltOXZiRjkwY25WbFFEa3pPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbTFoYVc1ZlltOXZiRjl0WlhKblpVQTVOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnphV2R1WldRZ1lYSnBkR2h0WlhScFl5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZiRjltWVd4elpVQTVORG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmWW05dmJGOXRaWEpuWlVBNU5Rb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGd6T2dvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE5Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGd3T2dvZ0lDQWdaR2xuSURFeENpQWdJQ0JpZFhKNUlERXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTRNUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnMU9nb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTROd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JpTFFvZ0lDQWdZblZ5ZVNBNUNncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPRGc2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTU2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU1Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmlMUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURreE9nb2dJQ0FnWkdsbklEa0tJQ0FnSUdJcUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWo0S0lDQWdJQ0VLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGt5Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9UQTZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGt4Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9EYzZDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT0RnS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNOZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZkbWxoV1hWc0wyUmxkR1ZqZEY5dGRXeGZiM1psY21ac2IzZGZjMmxuYm1Wa0xuTnZiQzVETG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUUFnQ0lELy8vLy8vLy8vL3dFbUJ4VUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVFBaEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRklBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFZQWdnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUZSOThkU05IQm9BQVJ3U0JnQ0N2U1RVRk5RQTBBSUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQmNRRFVBTVJoQUFBSWlRekVaRkVReEdFU0NBd1Fya0lML0JQdmZoOVVFdVpxTGJEWWFBSTREQWlVQkFnQUJBRFlhQVVsRkRSV0JGQkpFTmhvQ1NVVU1GWUVVRWtReEZrRUE0akVXSWdrNENCUkVTd29vcWtsRkNJQUFxRUFBTlVzTEtLcEpSUWNycEVsRkJCUkxCeXVrU1VVRUZCSkJBSXRMQWtBQWZ5aExCcUZGQ2tzQlFBQnZLRXNIb1VzS295dWtRUUJmSWtSTEN5aXFTd2VqS0txQUZQLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy9yRWtycDBFQU5JQWcvLy8vLy8vLy8vLy8vLy8vQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDZ0txcEpGU1FPUkNTdnF5Y0dURkN3SWtOQy8rNGpRditlU3daQy81QkxCVVVLUXYrQVN3SkFBQjBvU3dhaFJRbExBVUFBRFNoTEI2RkxDYU1ycFJSQy8zRkxCa0wvOGtzRlJRbEMvK0lqUXY4Z05ob0JTUlVsRWtRWFJRVTJHZ0pKRlNVU1JCZEZCREVXUVFFRU1SWWlDVGdJRkVSTEJJRi9Ea0FBQ0VzRUlRUVBRUURvSWtSTEE0Ri9Ea0FBQ0VzRElRUVBRUURTSWtSTEF4WXBxa2xGQjRBQXFFQUFORXNFRmltcVNVVUpKd1NrU1JSTEJ5Y0VwRWxGQkJRU1FRQ0JRQUIzS1VzSW9VVUtTVUFBYUNsTEJxRkxDcU1uQktSQkFGY2lSQ1d2U3dVV0thcExCNk1wcWxCSkZTVUpKVmlBQWYrc1NTY0VwMEVBTklBZy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vd0NnS3FwSkZTUU9SQ1N2cXljR1RGQ3dJa05DLys0alF2K21Td1ZDLzVkTEIwVUtRditJUUFBZEtVc0lvVVVKU1VBQURpbExCcUZMQ2FNbkJLVVVRdjk3U3dWQy8vRkxCMFVKUXYvaUkwTC9LeU5DL3hValF2NytOaG9CU1VVTkZTUVNSRFlhQWtsRkRCVWtFa1F4RmtFQWp6RVdJZ2s0Q0JSRVN3cUFBS2hBQUM5TEN5Y0ZwRWtVU3d3bkJhUkpSUVlVRWtFQVEwQUFPU3BMREtGRkNrc0NRQUFwS2tzTG9Vc0tveWNGcEVFQUdDSkVTd3RMQzZNcXFra1ZKQTVFSksrckp3Wk1VTEFpUXlOQy8rVkxDa0wvMWtzTFJRcEMvOFpBQUI0cVN3eWhSUWxMQWtBQURpcExDNkZMQ2FNbkJhVVVRdis1U3dwQy8vRkxDMFVKUXYvaEkwTC9jdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
