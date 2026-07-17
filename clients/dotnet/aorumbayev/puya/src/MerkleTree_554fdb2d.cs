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

namespace Arc56.Generated.aorumbayev.puya.MerkleTree_554fdb2d
{


    public class MerkleTreeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MerkleTreeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="root"> </param>
        public async Task Create(byte[] root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 36, 32, 59 };
            var rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rootAbi.From(root);

            var result = await base.CallApp(new List<object> { abiHandle, rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(byte[] root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 36, 32, 59 };
            var rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rootAbi.From(root);

            return await base.MakeTransactionList(new List<object> { abiHandle, rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proof"> </param>
        /// <param name="leaf"> </param>
        public async Task<bool> Verify(byte[][] proof, byte[] leaf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 41, 10, 213 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);

            var result = await base.CallApp(new List<object> { abiHandle, proofAbi, leafAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Verify_Transactions(byte[][] proof, byte[] leaf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 41, 10, 213 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofAbi, leafAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVya2xlVHJlZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb290IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVhZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQsNzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucm9vdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luSnZiM1FpQ2lBZ0lDQXZMeUJ0WlhKcmJHVXZZMjl1ZEhKaFkzUXVjSGs2T1FvZ0lDQWdMeThnWTJ4aGMzTWdUV1Z5YTJ4bFZISmxaU2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNE5ESTBNakF6WWlBd2VHTXdNamt3WVdRMUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtHSjVkR1ZiTXpKZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5abGNtbG1lU2hpZVhSbFd6TXlYVnRkTEdKNWRHVmJNekpkS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlY5eWIzVjBaVUF6SUcxaGFXNWZkbVZ5YVdaNVgzSnZkWFJsUURRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdiV1Z5YTJ4bEwyTnZiblJ5WVdOMExuQjVPamtLSUNBZ0lDOHZJR05zWVhOeklFMWxjbXRzWlZSeVpXVW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTJaWEpwWm5sZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUcxbGNtdHNaUzlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJRzFsY210c1pTOWpiMjUwY21GamRDNXdlVG81Q2lBZ0lDQXZMeUJqYkdGemN5Qk5aWEpyYkdWVWNtVmxLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJRzFsY210c1pTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhabGNtbG1lUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdiV1Z5YTJ4bEwyTnZiblJ5WVdOMExuQjVPakV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNBdkx5QnRaWEpyYkdVdlkyOXVkSEpoWTNRdWNIazZPUW9nSUNBZ0x5OGdZMnhoYzNNZ1RXVnlhMnhsVkhKbFpTaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnRaWEpyYkdVdlkyOXVkSEpoWTNRdWNIazZNVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1dFpYSnJiR1V1WTI5dWRISmhZM1F1VFdWeWEyeGxWSEpsWlM1amNtVmhkR1VvY205dmREb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUcxbGNtdHNaUzlqYjI1MGNtRmpkQzV3ZVRveE1DMHhNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0F2THlCa1pXWWdZM0psWVhSbEtITmxiR1lzSUhKdmIzUTZJRUo1ZEdWek16SXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUcxbGNtdHNaUzlqYjI1MGNtRmpkQzV3ZVRveE1nb2dJQ0FnTHk4Z2MyVnNaaTV5YjI5MElEMGdjbTl2ZEM1aWVYUmxjd29nSUNBZ1lubDBaV05mTUNBdkx5QWljbTl2ZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG0xbGNtdHNaUzVqYjI1MGNtRmpkQzVOWlhKcmJHVlVjbVZsTG5abGNtbG1lU2h3Y205dlpqb2dZbmwwWlhNc0lHeGxZV1k2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q25abGNtbG1lVG9LSUNBZ0lDOHZJRzFsY210c1pTOWpiMjUwY21GamRDNXdlVG94TkMweE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2RtVnlhV1o1S0hObGJHWXNJSEJ5YjI5bU9pQlFjbTl2Wml3Z2JHVmhaam9nUW5sMFpYTXpNaWtnTFQ0Z1ltOXZiRG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2JXVnlhMnhsTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV5YjI5MElEMDlJR052YlhCMWRHVmZjbTl2ZEY5b1lYTm9LSEJ5YjI5bUxDQnNaV0ZtTG1KNWRHVnpLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSnZiM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtOXZkQ0JsZUdsemRITUtJQ0FnSUM4dklHMWxjbXRzWlM5amIyNTBjbUZqZEM1d2VUb3lNZ29nSUNBZ0x5OGdabTl5SUdsa2VDQnBiaUIxY21GdVoyVW9jSEp2YjJZdWJHVnVaM1JvS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDZ3AyWlhKcFpubGZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnYldWeWEyeGxMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCbWIzSWdhV1I0SUdsdUlIVnlZVzVuWlNod2NtOXZaaTVzWlc1bmRHZ3BPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0E4Q2lBZ0lDQmllaUIyWlhKcFpubGZZV1owWlhKZlptOXlRRGNLSUNBZ0lDOHZJRzFsY210c1pTOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWTI5dGNIVjBaV1FnUFNCb1lYTm9YM0JoYVhJb1kyOXRjSFYwWldRc0lIQnliMjltVzJsa2VGMHVZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0F2THlCdFpYSnJiR1V2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNXphR0V5TlRZb1lTQXJJR0lnYVdZZ1FtbG5WVWx1ZEM1bWNtOXRYMko1ZEdWektHRXBJRHdnUW1sblZVbHVkQzVtY205dFgySjVkR1Z6S0dJcElHVnNjMlVnWWlBcklHRXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWo0S0lDQWdJR0o2SUhabGNtbG1lVjkwWlhKdVlYSjVYMlpoYkhObFFEVUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtDblpsY21sbWVWOTBaWEp1WVhKNVgyMWxjbWRsUURZNkNpQWdJQ0F2THlCdFpYSnJiR1V2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNXphR0V5TlRZb1lTQXJJR0lnYVdZZ1FtbG5WVWx1ZEM1bWNtOXRYMko1ZEdWektHRXBJRHdnUW1sblZVbHVkQzVtY205dFgySjVkR1Z6S0dJcElHVnNjMlVnWWlBcklHRXBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ0x5OGdiV1Z5YTJ4bEwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJtYjNJZ2FXUjRJR2x1SUhWeVlXNW5aU2h3Y205dlppNXNaVzVuZEdncE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdJZ2RtVnlhV1o1WDJadmNsOW9aV0ZrWlhKQU1nb0tkbVZ5YVdaNVgzUmxjbTVoY25sZlptRnNjMlZBTlRvS0lDQWdJQzh2SUcxbGNtdHNaUzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xuTm9ZVEkxTmloaElDc2dZaUJwWmlCQ2FXZFZTVzUwTG1aeWIyMWZZbmwwWlhNb1lTa2dQQ0JDYVdkVlNXNTBMbVp5YjIxZllubDBaWE1vWWlrZ1pXeHpaU0JpSUNzZ1lTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdJZ2RtVnlhV1o1WDNSbGNtNWhjbmxmYldWeVoyVkFOZ29LZG1WeWFXWjVYMkZtZEdWeVgyWnZja0EzT2dvZ0lDQWdMeThnYldWeWEyeGxMMk52Ym5SeVlXTjBMbkI1T2pFMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXliMjkwSUQwOUlHTnZiWEIxZEdWZmNtOXZkRjlvWVhOb0tIQnliMjltTENCc1pXRm1MbUo1ZEdWektRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQTlQUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVnSmdFRWNtOXZkREViUVFBVmdnSUVoQ1FnT3dUQUtRclZOaG9BamdJQUpBQUNJa014R1JSRU1SaEVOaG9CTmhvQ2lBQXFnQUVBSWs4Q1ZJQUVGUjk4ZFV4UXNDTkRNUmtVUkRFWUZFUTJHZ0dJQUFJalE0b0JBQ2lMLzJlSmlnSUJJaWhsUkl2K0lsa2lpLytMQW9zQkRFRUFLSXYrVndJQWl3SWtDeVJZU1lzRHBVRUFFSXNEVEZBQmpBT0xBaU1JakFKQy85YUxBMUJDLys2TEFJc0RFb3dBaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
