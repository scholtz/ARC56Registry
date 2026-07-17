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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.ITxnOpsContract_35ab92cc
{


    public class ITxnOpsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ITxnOpsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task VerifyItxnOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 124, 217, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyItxnOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 124, 217, 203 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSVR4bk9wc0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InZlcmlmeV9pdHhuX29wcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURZZ01UQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREEyT0RFd01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qUTVNZ29nSUNBZ0x5OGdZMnhoYzNNZ1NWUjRiazl3YzBOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWlRkalpEbGpZaUF2THlCdFpYUm9iMlFnSW5abGNtbG1lVjlwZEhodVgyOXdjeWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRtVnlhV1o1WDJsMGVHNWZiM0J6WDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOTJaWEpwWm5sZmFYUjRibDl2Y0hOZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvME9UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjJaWEpwWm5sZmFYUjRibDl2Y0hNS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFOVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExrbFVlRzVQY0hORGIyNTBjbUZqZEM1MlpYSnBabmxmYVhSNGJsOXZjSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmYVhSNGJsOXZjSE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TkRrMUNpQWdJQ0F2THlCaGJHZHZjSGt1YjNBdVNWUjRia055WldGMFpTNWlaV2RwYmlncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TkRrMkNpQWdJQ0F2THlCaGJHZHZjSGt1YjNBdVNWUjRia055WldGMFpTNXpaWFJmZEhsd1pWOWxiblZ0S0dGc1oyOXdlUzVVY21GdWMyRmpkR2x2YmxSNWNHVXVRWEJ3YkdsallYUnBiMjVEWVd4c0tRb2dJQ0FnYVc1MFkxOHhJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvME9UY0tJQ0FnSUM4dklHRnNaMjl3ZVM1dmNDNUpWSGh1UTNKbFlYUmxMbk5sZEY5dmJsOWpiMjF3YkdWMGFXOXVLR0ZzWjI5d2VTNVBia052YlhCc1pYUmxRV04wYVc5dUxrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUtRb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qUTVPQW9nSUNBZ0x5OGdZV3huYjNCNUxtOXdMa2xVZUc1RGNtVmhkR1V1YzJWMFgyRndjSEp2ZG1Gc1gzQnliMmR5WVcwb1FubDBaWE11Wm5KdmJWOW9aWGdvSWpBMk9ERXdNU0lwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvME9Ua3ROVEF3Q2lBZ0lDQXZMeUFqSUhCaFoyVnpJR1Z6YzJWdWRHbGhiR3g1SUdGd2NHVnVaSE1LSUNBZ0lDOHZJR0ZzWjI5d2VTNXZjQzVKVkhodVEzSmxZWFJsTG5ObGRGOWhjSEJ5YjNaaGJGOXdjbTluY21GdFgzQmhaMlZ6S0VKNWRHVnpMbVp5YjIxZmFHVjRLQ0l3TmpneE1ERWlLU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzFNREVLSUNBZ0lDOHZJR0ZzWjI5d2VTNXZjQzVKVkhodVEzSmxZWFJsTG5ObGRGOWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLRUo1ZEdWekxtWnliMjFmYUdWNEtDSXdOamd4TURFaUtTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dOamd4TURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8xTURJS0lDQWdJQzh2SUdGc1oyOXdlUzV2Y0M1SlZIaHVRM0psWVhSbExuTmxkRjltWldVb1lXeG5iM0I1TG05d0xrZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTa0tJQ0FnSUdkc2IySmhiQ0JOYVc1VWVHNUdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TlRBekNpQWdJQ0F2THlCaGJHZHZjSGt1YjNBdVNWUjRia055WldGMFpTNXVaWGgwS0NrS0lDQWdJR2wwZUc1ZmJtVjRkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPalV3TkFvZ0lDQWdMeThnWVd4bmIzQjVMbTl3TGtsVWVHNURjbVZoZEdVdWMyVjBYM1I1Y0dWZlpXNTFiU2hoYkdkdmNIa3VWSEpoYm5OaFkzUnBiMjVVZVhCbExsQmhlVzFsYm5RcENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TlRBMUNpQWdJQ0F2THlCaGJHZHZjSGt1YjNBdVNWUjRia055WldGMFpTNXpaWFJmY21WalpXbDJaWElvWVd4bmIzQjVMbTl3TGtkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXBDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMU1EWUtJQ0FnSUM4dklHRnNaMjl3ZVM1dmNDNUpWSGh1UTNKbFlYUmxMbk5sZEY5aGJXOTFiblFvWVd4bmIzQjVMbFZKYm5RMk5DZ3hNREF3S1NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPalV3TndvZ0lDQWdMeThnWVd4bmIzQjVMbTl3TGtsVWVHNURjbVZoZEdVdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TlRBNUNpQWdJQ0F2THlCaGMzTmxjblFnWVd4bmIzQjVMbTl3TGtsVWVHNHVjbVZqWldsMlpYSW9LU0E5UFNCaGJHZHZjSGt1YjNBdVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ2FYUjRiaUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOVEV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV3huYjNCNUxtOXdMa2xVZUc0dVlXMXZkVzUwS0NrZ1BUMGdZV3huYjNCNUxsVkpiblEyTkNneE1EQXdLUW9nSUNBZ2FYUjRiaUJCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOVEV4Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV3huYjNCNUxtOXdMa2xVZUc0dWRIbHdaVjlsYm5WdEtDa2dQVDBnWVd4bmIzQjVMbFJ5WVc1ellXTjBhVzl1Vkhsd1pTNVFZWGx0Wlc1MENpQWdJQ0JwZEhodUlGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk5URXpDaUFnSUNBdkx5QmhjM05sY25RZ1lXeG5iM0I1TG05d0xrZEpWSGh1TG5SNWNHVmZaVzUxYlNnd0tTQTlQU0JoYkdkdmNIa3VWSEpoYm5OaFkzUnBiMjVVZVhCbExrRndjR3hwWTJGMGFXOXVRMkZzYkFvZ0lDQWdaMmwwZUc0Z01DQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzFNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiR2R2Y0hrdWIzQXVSMGxVZUc0dWRIbHdaVjlsYm5WdEtERXBJRDA5SUdGc1oyOXdlUzVVY21GdWMyRmpkR2x2YmxSNWNHVXVVR0Y1YldWdWRBb2dJQ0FnWjJsMGVHNGdNU0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPalE1TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRYm9CeVlCQXdhQkFURWJRUUFZZ0FST2ZObkxOaG9BamdFQUFRQXhHUlF4R0JCRVFnQUlNUmtVTVJnVUVFT3hJN0lRZ1FXeUdTaXlIaWl5UUNpeUh6SUFzZ0cySXJJUU1nbXlCeVN5Q0xPMEJ6SUpFa1MwQ0NRU1JMUVFJaEpFdHdBUUl4SkV0d0VRSWhKRUlrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
