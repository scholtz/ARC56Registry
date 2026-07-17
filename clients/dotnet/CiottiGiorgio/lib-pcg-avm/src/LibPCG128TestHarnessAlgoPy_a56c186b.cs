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

namespace Arc56.Generated.CiottiGiorgio.lib_pcg_avm.LibPCG128TestHarnessAlgoPy_a56c186b
{


    public class LibPCG128TestHarnessAlgoPyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LibPCG128TestHarnessAlgoPyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seed"> </param>
        /// <param name="lower_bound"> </param>
        /// <param name="upper_bound"> </param>
        /// <param name="length"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt128[]> GetPcg128SequenceArc4Uint128Return(byte[] seed, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 lower_bound, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 93, 95, 44 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); seedAbi.From(seed);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, seedAbi, lower_bound, upper_bound, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetPcg128SequenceArc4Uint128Return_Transactions(byte[] seed, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 lower_bound, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 upper_bound, ushort length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 93, 95, 44 };
            var seedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); seedAbi.From(seed);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, seedAbi, lower_bound, upper_bound, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeAssertsPcg128StackArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 55, 244, 47 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeAssertsPcg128StackArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 55, 244, 47 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RuntimeFailureStackBytesliceOverflow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RuntimeFailureStackBytesliceOverflow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 11, 72, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGliUENHMTI4VGVzdEhhcm5lc3NBbGdvUHkiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X3BjZzEyOF9zZXF1ZW5jZV9hcmM0X3VpbnQxMjhfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDEyOCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxvd2VyX2JvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTI4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBwZXJfYm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MTI4W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bnRpbWVfYXNzZXJ0c19wY2cxMjhfc3RhY2tfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicnVudGltZV9mYWlsdXJlX3N0YWNrX2J5dGVzbGljZV9vdmVyZmxvdyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzcyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzUsNzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDEyOCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxNiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBMk16WTBNVE0yTWpJek9EUTJOemt6TURBMUlERWdOREk1TkRrMk56STVOU0F6TWlBeE5EUXlOamsxTURRd09EZzRPVFl6TkRBM0lERTBOREkyT1RVd05EQTRPRGc1TmpNME1Ea2dNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXhNU0F4TkRReU5qazFNRFF3T0RnNE9UWXpOREV6Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0SURCNE1ERWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TUFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkdFMVpEVm1NbU1nTUhoalpUTTNaalF5WmlBd2VEWmpNR0kwT0RrNElDOHZJRzFsZEdodlpDQWlaMlYwWDNCalp6RXlPRjl6WlhGMVpXNWpaVjloY21NMFgzVnBiblF4TWpoZmNtVjBkWEp1S0dKNWRHVmJNekpkTEhWcGJuUXhNamdzZFdsdWRERXlPQ3gxYVc1ME1UWXBkV2x1ZERFeU9GdGRJaXdnYldWMGFHOWtJQ0p5ZFc1MGFXMWxYMkZ6YzJWeWRITmZjR05uTVRJNFgzTjBZV05yWDJGeWNtRjVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlkVzUwYVcxbFgyWmhhV3gxY21WZmMzUmhZMnRmWW5sMFpYTnNhV05sWDI5MlpYSm1iRzkzS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjJWMFgzQmpaekV5T0Y5elpYRjFaVzVqWlY5aGNtTTBYM1ZwYm5ReE1qaGZjbVYwZFhKdUlISjFiblJwYldWZllYTnpaWEowYzE5d1kyY3hNamhmYzNSaFkydGZZWEp5WVhrZ2NuVnVkR2x0WlY5bVlXbHNkWEpsWDNOMFlXTnJYMko1ZEdWemJHbGpaVjl2ZG1WeVpteHZkd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFd09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCc2FXSmZjR05uTG5Calp6RXlPQzV3WTJjeE1qaGZhVzVwZENoelpXVmtPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncHdZMmN4TWpoZmFXNXBkRG9LSUNBZ0lIQnliM1J2SURFZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR05mTUNBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR01nTkNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdOU0F2THlBeE5EUXlOamsxTURRd09EZzRPVFl6TkRBNUNpQWdJQ0JoWkdSM0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEWXpOalF4TXpZeU1qTTRORFkzT1RNd01EVUtJQ0FnSUcxMWJIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZeUExSUM4dklERTBOREkyT1RVd05EQTRPRGc1TmpNME1Ea0tJQ0FnSUdGa1pIY0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdOaUF2THlBeE5EUXlOamsxTURRd09EZzRPVFl6TkRFeENpQWdJQ0JoWkdSM0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEWXpOalF4TXpZeU1qTTRORFkzT1RNd01EVUtJQ0FnSUcxMWJIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZeUEySUM4dklERTBOREkyT1RVd05EQTRPRGc1TmpNME1URUtJQ0FnSUdGa1pIY0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTNJQzh2SURFME5ESTJPVFV3TkRBNE9EZzVOak0wTVRNS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVdSa2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z05qTTJOREV6TmpJeU16ZzBOamM1TXpBd05Rb2dJQ0FnYlhWc2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpJRGNnTHk4Z01UUTBNalk1TlRBME1EZzRPRGsyTXpReE13b2dJQ0FnWVdSa2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnNhV0pmY0dObkxuQmpaekV5T0M1d1kyY3hNamhmY21GdVpHOXRLSE4wWVhSbExqQTZJSFZwYm5RMk5Dd2djM1JoZEdVdU1Ub2dkV2x1ZERZMExDQnpkR0YwWlM0eU9pQjFhVzUwTmpRc0lITjBZWFJsTGpNNklIVnBiblEyTkN3Z2JHOTNaWEpmWW05MWJtUTZJR0o1ZEdWekxDQjFjSEJsY2w5aWIzVnVaRG9nWW5sMFpYTXNJR3hsYm1kMGFEb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lHSjVkR1Z6T2dwd1kyY3hNamhmY21GdVpHOXRPZ29nSUNBZ2NISnZkRzhnTnlBMUNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnBkR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQndZMmN4TWpoZmNtRnVaRzl0WDJWc2MyVmZZbTlrZVVBM0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nY0dObk1USTRYM0poYm1SdmJWOWxiSE5sWDJKdlpIbEFOd29nSUNBZ2NIVnphR2x1ZENBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0NuQmpaekV5T0Y5eVlXNWtiMjFmWm05eVgyaGxZV1JsY2tBek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQQW9nSUNBZ1lub2djR05uTVRJNFgzSmhibVJ2YlY5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVGNLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOaGJHeHpkV0lnWDE5d1kyY3hNamhmZFc1aWIzVnVaR1ZrWDNKaGJtUnZiUW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdabkpoYldWZlluVnllU0F0TkFvZ0lDQWdabkpoYldWZlluVnllU0F0TlFvZ0lDQWdabkpoYldWZlluVnllU0F0TmdvZ0lDQWdabkpoYldWZlluVnllU0F0TndvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdZaUJ3WTJjeE1qaGZjbUZ1Wkc5dFgyWnZjbDlvWldGa1pYSkFNd29LY0dObk1USTRYM0poYm1SdmJWOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwM0NpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUhKbGRITjFZZ29LY0dObk1USTRYM0poYm1SdmJWOWxiSE5sWDJKdlpIbEFOem9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQndZMmN4TWpoZmNtRnVaRzl0WDJWc2MyVmZZbTlrZVVBNUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWo0S0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZandLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0l0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSStDaUFnSUNCaGMzTmxjblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaUxRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncHdZMmN4TWpoZmNtRnVaRzl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCaWZnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCemQyRndDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29LY0dObk1USTRYM0poYm1SdmJWOW1iM0pmYUdWaFpHVnlRREV4T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BBb2dJQ0FnWW5vZ2NHTm5NVEk0WDNKaGJtUnZiVjloWm5SbGNsOXBabDlsYkhObFFESXdDZ3B3WTJjeE1qaGZjbUZ1Wkc5dFgzZG9hV3hsWDNSdmNFQXhNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXROd29nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTJGc2JITjFZaUJmWDNCalp6RXlPRjkxYm1KdmRXNWtaV1JmY21GdVpHOXRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXROQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXROUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXROZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXROd29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdJK1BRb2dJQ0FnWW5vZ2NHTm5NVEk0WDNKaGJtUnZiVjkzYUdsc1pWOTBiM0JBTVRNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWWlzS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lpQndZMmN4TWpoZmNtRnVaRzl0WDJadmNsOW9aV0ZrWlhKQU1URUtDbkJqWnpFeU9GOXlZVzVrYjIxZlpXeHpaVjlpYjJSNVFEazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaUxRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpSUhCalp6RXlPRjl5WVc1a2IyMWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tDaTh2SUd4cFlsOXdZMmN1Y0dObk1USTRMbDlmY0dObk1USTRYM1Z1WW05MWJtUmxaRjl5WVc1a2IyMG9jM1JoZEdVdU1Eb2dkV2x1ZERZMExDQnpkR0YwWlM0eE9pQjFhVzUwTmpRc0lITjBZWFJsTGpJNklIVnBiblEyTkN3Z2MzUmhkR1V1TXpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUdKNWRHVnpPZ3BmWDNCalp6RXlPRjkxYm1KdmRXNWtaV1JmY21GdVpHOXRPZ29nSUNBZ2NISnZkRzhnTkNBMUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TkRReU5qazFNRFF3T0RnNE9UWXpOREEzQ2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1IxY0FvZ0lDQWdJUW9nSUNBZ2FXNTBZeUExSUM4dklERTBOREkyT1RVd05EQTRPRGc1TmpNME1Ea0tJQ0FnSUhOM1lYQUtJQ0FnSUhOb2JBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwYm5Salh6QWdMeThnTmpNMk5ERXpOakl5TXpnME5qYzVNekF3TlFvZ0lDQWdiWFZzZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoWkdSM0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdhVzUwWXlBMklDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNVEVLSUNBZ0lITjNZWEFLSUNBZ0lITm9iQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z05qTTJOREV6TmpJeU16ZzBOamM1TXpBd05Rb2dJQ0FnYlhWc2R3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUjFjQW9nSUNBZ0lRb2dJQ0FnYVc1MFl5QTNJQzh2SURFME5ESTJPVFV3TkRBNE9EZzVOak0wTVRNS0lDQWdJSE4zWVhBS0lDQWdJSE5vYkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOak0yTkRFek5qSXlNemcwTmpjNU16QXdOUW9nSUNBZ2JYVnNkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdjSFZ6YUdsdWRDQXhPQW9nSUNBZ2MyaHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUY0S0lDQWdJSEIxYzJocGJuUWdNamNLSUNBZ0lITm9jZ29nSUNBZ2FXNTBZMTh5SUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdjSFZ6YUdsdWRDQTFPUW9nSUNBZ2MyaHlDaUFnSUNCa2RYQXlDaUFnSUNCemFISUtJQ0FnSUhOM1lYQUtJQ0FnSUg0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJSEIxYzJocGJuUWdNekVLSUNBZ0lDWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjMmhzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnZkFvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQnphR3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnYzJoeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRjRLSUNBZ0lIQjFjMmhwYm5RZ01qY0tJQ0FnSUhOb2Nnb2dJQ0FnYVc1MFkxOHlJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR2x1ZENBMU9Rb2dJQ0FnYzJoeUNpQWdJQ0JrZFhBeUNpQWdJQ0J6YUhJS0lDQWdJSE4zWVhBS0lDQWdJSDRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lIQjFjMmhwYm5RZ016RUtJQ0FnSUNZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MyaHNDaUFnSUNCcGJuUmpYeklnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdmQW9nSUNBZ2ZBb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJREU0Q2lBZ0lDQnphSElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1hnb2dJQ0FnY0hWemFHbHVkQ0F5TndvZ0lDQWdjMmh5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRFU1Q2lBZ0lDQnphSElLSUNBZ0lHUjFjRElLSUNBZ0lITm9jZ29nSUNBZ2MzZGhjQW9nSUNBZ2Znb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnY0hWemFHbHVkQ0F6TVFvZ0lDQWdKZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6YUd3S0lDQWdJR2x1ZEdOZk1pQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCOENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJSE5vYkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNCemFISUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWGdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ2MyaHlDaUFnSUNCcGJuUmpYeklnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEVTVDaUFnSUNCemFISUtJQ0FnSUdSMWNESUtJQ0FnSUhOb2Nnb2dJQ0FnYzNkaGNBb2dJQ0FnZmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpNUW9nSUNBZ0pnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnphR3dLSUNBZ0lHbHVkR05mTWlBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0I4Q2lBZ0lDQjhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhV0pmY0dObk1USTRYM1JsYzNSZmFHRnlibVZ6Y3k1amIyNTBjbUZqZEM1TWFXSlFRMGN4TWpoVVpYTjBTR0Z5Ym1WemMwRnNaMjlRZVM1blpYUmZjR05uTVRJNFgzTmxjWFZsYm1ObFgyRnlZelJmZFdsdWRERXlPRjl5WlhSMWNtNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNHTm5NVEk0WDNObGNYVmxibU5sWDJGeVl6UmZkV2x1ZERFeU9GOXlaWFIxY200NkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReE1qZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXhNamdLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnY0dObk1USTRYMmx1YVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyRnNiSE4xWWlCd1kyY3hNamhmY21GdVpHOXRDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQndiM0J1SURRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNhV0pmY0dObk1USTRYM1JsYzNSZmFHRnlibVZ6Y3k1amIyNTBjbUZqZEM1TWFXSlFRMGN4TWpoVVpYTjBTR0Z5Ym1WemMwRnNaMjlRZVM1eWRXNTBhVzFsWDJGemMyVnlkSE5mY0dObk1USTRYM04wWVdOclgyRnljbUY1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NuVnVkR2x0WlY5aGMzTmxjblJ6WDNCalp6RXlPRjl6ZEdGamExOWhjbkpoZVRvS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR05oYkd4emRXSWdjR05uTVRJNFgybHVhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5UVUtJQ0FnSUdOaGJHeHpkV0lnY0dObk1USTRYM0poYm1SdmJRb2dJQ0FnY0c5d2JpQTFDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14cFlsOXdZMmN4TWpoZmRHVnpkRjlvWVhKdVpYTnpMbU52Ym5SeVlXTjBMa3hwWWxCRFJ6RXlPRlJsYzNSSVlYSnVaWE56UVd4bmIxQjVMbkoxYm5ScGJXVmZabUZwYkhWeVpWOXpkR0ZqYTE5aWVYUmxjMnhwWTJWZmIzWmxjbVpzYjNkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlkVzUwYVcxbFgyWmhhV3gxY21WZmMzUmhZMnRmWW5sMFpYTnNhV05sWDI5MlpYSm1iRzkzT2dvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZMkZzYkhOMVlpQndZMmN4TWpoZmFXNXBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMU5nb2dJQ0FnWTJGc2JITjFZaUJ3WTJjeE1qaGZjbUZ1Wkc5dENpQWdJQ0J3YjNCdUlEVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFJcmY3VjVOU0YvYWhZQWYvLy8vOFBJTStDbnJ2djc5NkNGTkdDbnJ2djc5NkNGTk9DbnJ2djc5NkNGTldDbnJ2djc5NkNGQ1lEQUFFQkVRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQU1SdEJBQ1F4R1JSRU1SaEVnZ01FMmwxZkxBVE9OL1F2Qkd3TFNKZzJHZ0NPQXdKWkFwNENyd0F4R1JReEdCUVFRNG9CQkl2L0ZTVVNSSXYvZ1FCYmdRQWlIVVVCU1NFRUhrVUJUd0llUlFFaUhVVUJJUVFlVGdKSWkvK0JDRnRMQVNFRkhrVUJIa1VCSWgxRkFTRUZIazRDU0l2L2dSQmJTd0VoQmg1RkFSNUZBU0lkUlFFaEJoNU9Ba2lMLzRFWVcwd2hCeDVGQVI1RkFTSWRSUUVoQng1RkFZbUtCd1dCQUVjQ0tJdi9Ga21UZ1JBT1JGY0dBb3Y5S0toQkFFeUwvaWlvUVFCRmdRQ01BNHNEaS84TVFRQWtpL21MK292N2kveUlBTTlPQkl6OGpQdU0rb3o1aXdSTVVJd0Vpd01qQ0l3RFF2L1VpL21MK292N2kveUxCRThKVHdsUENVOEpUd21KaS80b3FVRUFlNHYrS2FWRWkvNHFwRVNML2ltaGkvMmxSSXYraS8yaGpBQ0xBRW11S2FDQUVQLy8vLy8vLy8vLy8vLy8vLy8vLy8rc1RLcU1Bb0VBakFPTEE0di9ERUgvb292NWkvcUwrNHY4aUFCTlNVNEZqQUdNL0l6N2pQcU0rWXNDcDBILzRvc0Jpd0NxaS8yZ2dSQ3ZxNHNFVEZDTUJJc0RJd2lNQTBML3Y0djlnQkNBQUFBQUFBQUFBQUFBQUFBQUFBQUFwRVFxaS8yaGpBQkMvMytLQkFXTC9DSWRSUUVoQkI1RkFVa1VJUVZNa0l2OUloMUZBUjVGQVVrVUlRWk1rSXYrSWgxRkFSNUZBVWtVSVFkTWtJdi9JaDFGQVI1RkFZdjhnUktSaS93YmdSdVJKQnFML0lFN2tVcVJUQndqSGtVQmdSOGFUd0pNa0NRYUdTV1FpLzJCRXBHTC9SdUJHNUVrR292OWdUdVJTcEZNSENNZVJRR0JIeHBQQWt5UUpCb1pHUmFML29FU2tZditHNEVia1NRYWkvNkJPNUZLa1V3Y0l4NUZBWUVmR2s4Q1RKQWtHaGtsa0l2L2dSS1JpLzhiZ1J1UkpCcUwvNEU3a1VxUlRCd2pIa1VCZ1I4YVR3Sk1rQ1FhR1JrV1VJazJHZ0ZKRlNVU1JEWWFBa2tWZ1JBU1JEWWFBMGtWZ1JBU1JEWWFCRWtWZ1FJU1JFOERpUDJJVHdRWFRnUlBCazhHVHdhSS9lMU9CRVlFZ0FRVkgzeDFURkN3STBNbHI0ajlaaWhKZ2Y4QmlQM1JSZ1VqUXlXdmlQMVZLRW1CZ0FLSS9jQkdCU05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
