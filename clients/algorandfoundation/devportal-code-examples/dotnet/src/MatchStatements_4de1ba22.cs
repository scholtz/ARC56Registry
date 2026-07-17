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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.MatchStatements_4de1ba22
{


    public class MatchStatementsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MatchStatementsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="date"> </param>
        public async Task<string> GetDay(ulong date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 164, 234, 82 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dateAbi.From(date);

            var result = await base.CallApp(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetDay_Transactions(ulong date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 164, 234, 82 };
            var dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dateAbi.From(date);

            return await base.MakeTransactionList(new List<object> { abiHandle, dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWF0Y2hTdGF0ZW1lbnRzIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldF9kYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbTlzWDJac2IzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRNdE5UUUtJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dUVUZVUTBnS0lDQWdJQzh2SUdOc1lYTnpJRTFoZEdOb1UzUmhkR1Z0Wlc1MGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpUVmhOR1ZoTlRJZ0x5OGdiV1YwYUc5a0lDSm5aWFJmWkdGNUtIVnBiblEyTkNsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmRsZEY5a1lYbGZjbTkxZEdWQU13b2dJQ0FnWlhKeUNncHRZV2x1WDJkbGRGOWtZWGxmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY205c1gyWnNiM2N2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCaUlHZGxkRjlrWVhrS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFOVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1SUM4dklHOXVJR1Z5Y205eU9pQlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNTBjbTlzWDJac2IzY3VZMjl1ZEhKaFkzUXVUV0YwWTJoVGRHRjBaVzFsYm5SekxtZGxkRjlrWVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWkdGNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnliMnhmWm14dmR5OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEp2YkY5bWJHOTNMMk52Ym5SeVlXTjBMbkI1T2pVM0xUY3pDaUFnSUNBdkx5QnRZWFJqYUNCa1lYUmxPZ29nSUNBZ0x5OGdJQ0FnSUdOaGMyVWdWVWx1ZERZMEtEQXBPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlaWFIxY200Z1UzUnlhVzVuS0NKTmIyNWtZWGtpS1FvZ0lDQWdMeThnSUNBZ0lHTmhjMlVnVlVsdWREWTBLREVwT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J5WlhSMWNtNGdVM1J5YVc1bktDSlVkV1Z6WkdGNUlpa0tJQ0FnSUM4dklDQWdJQ0JqWVhObElGVkpiblEyTkNneUtUb0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2NtVjBkWEp1SUZOMGNtbHVaeWdpVjJWa2JtVnpaR0Y1SWlrS0lDQWdJQzh2SUNBZ0lDQmpZWE5sSUZWSmJuUTJOQ2d6S1RvS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnY21WMGRYSnVJRk4wY21sdVp5Z2lWR2gxY25Oa1lYa2lLUW9nSUNBZ0x5OGdJQ0FnSUdOaGMyVWdWVWx1ZERZMEtEUXBPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlaWFIxY200Z1UzUnlhVzVuS0NKR2NtbGtZWGtpS1FvZ0lDQWdMeThnSUNBZ0lHTmhjMlVnVlVsdWREWTBLRFVwT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J5WlhSMWNtNGdVM1J5YVc1bktDSlRZWFIxY21SaGVTSXBDaUFnSUNBdkx5QWdJQ0FnWTJGelpTQlZTVzUwTmpRb05pazZDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxkSFZ5YmlCVGRISnBibWNvSWxOMWJtUmhlU0lwQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JmT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J5WlhSMWNtNGdVM1J5YVc1bktDSkpiblpoYkdsa0lHUmhlU0lwQ2lBZ0lDQnpkMmwwWTJnZ1oyVjBYMlJoZVY5emQybDBZMmhmWTJGelpWOHdRRElnWjJWMFgyUmhlVjl6ZDJsMFkyaGZZMkZ6WlY4eFFETWdaMlYwWDJSaGVWOXpkMmwwWTJoZlkyRnpaVjh5UURRZ1oyVjBYMlJoZVY5emQybDBZMmhmWTJGelpWOHpRRFVnWjJWMFgyUmhlVjl6ZDJsMFkyaGZZMkZ6WlY4MFFEWWdaMlYwWDJSaGVWOXpkMmwwWTJoZlkyRnpaVjgxUURjZ1oyVjBYMlJoZVY5emQybDBZMmhmWTJGelpWODJRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY205c1gyWnNiM2N2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtsdWRtRnNhV1FnWkdGNUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNXNTJZV3hwWkNCa1lYa2lDZ3BuWlhSZlpHRjVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuUnliMnhmWm14dmR5NWpiMjUwY21GamRDNU5ZWFJqYUZOMFlYUmxiV1Z1ZEhNdVoyVjBYMlJoZVVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbTlzWDJac2IzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFgyUmhlVjl6ZDJsMFkyaGZZMkZ6WlY4MlFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEp2YkY5bWJHOTNMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pUZFc1a1lYa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlRkVzVrWVhraUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdJZ1oyVjBYMlJoZVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjUwY205c1gyWnNiM2N1WTI5dWRISmhZM1F1VFdGMFkyaFRkR0YwWlcxbGJuUnpMbWRsZEY5a1lYbEFNVEFLQ21kbGRGOWtZWGxmYzNkcGRHTm9YMk5oYzJWZk5VQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5YjJ4ZlpteHZkeTlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVTJGMGRYSmtZWGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUWVhSMWNtUmhlU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY205c1gyWnNiM2N2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZaUJuWlhSZlpHRjVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuUnliMnhmWm14dmR5NWpiMjUwY21GamRDNU5ZWFJqYUZOMFlYUmxiV1Z1ZEhNdVoyVjBYMlJoZVVBeE1Bb0taMlYwWDJSaGVWOXpkMmwwWTJoZlkyRnpaVjgwUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPalkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSkdjbWxrWVhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKR2NtbGtZWGtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKdmJGOW1iRzkzTDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0lnWjJWMFgyUmhlVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1amIyNTBjbTlzWDJac2IzY3VZMjl1ZEhKaFkzUXVUV0YwWTJoVGRHRjBaVzFsYm5SekxtZGxkRjlrWVhsQU1UQUtDbWRsZEY5a1lYbGZjM2RwZEdOb1gyTmhjMlZmTTBBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnliMnhmWm14dmR5OWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lWR2gxY25Oa1lYa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlVhSFZ5YzJSaGVTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbTlzWDJac2IzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lpQm5aWFJmWkdGNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5SeWIyeGZabXh2ZHk1amIyNTBjbUZqZEM1TllYUmphRk4wWVhSbGJXVnVkSE11WjJWMFgyUmhlVUF4TUFvS1oyVjBYMlJoZVY5emQybDBZMmhmWTJGelpWOHlRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKdmJGOW1iRzkzTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKWFpXUnVaWE5rWVhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKWFpXUnVaWE5rWVhraUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISnZiRjltYkc5M0wyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdJZ1oyVjBYMlJoZVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjUwY205c1gyWnNiM2N1WTI5dWRISmhZM1F1VFdGMFkyaFRkR0YwWlcxbGJuUnpMbWRsZEY5a1lYbEFNVEFLQ21kbGRGOWtZWGxmYzNkcGRHTm9YMk5oYzJWZk1VQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5YjJ4ZlpteHZkeTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVkhWbGMyUmhlU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFIxWlhOa1lYa2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEp2YkY5bWJHOTNMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSWdaMlYwWDJSaGVWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1MGNtOXNYMlpzYjNjdVkyOXVkSEpoWTNRdVRXRjBZMmhUZEdGMFpXMWxiblJ6TG1kbGRGOWtZWGxBTVRBS0NtZGxkRjlrWVhsZmMzZHBkR05vWDJOaGMyVmZNRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeWIyeGZabXh2ZHk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVRXOXVaR0Y1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFc5dVpHRjVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5YjJ4ZlpteHZkeTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmlJR2RsZEY5a1lYbGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWRISnZiRjltYkc5M0xtTnZiblJ5WVdOMExrMWhkR05vVTNSaGRHVnRaVzUwY3k1blpYUmZaR0Y1UURFd0NnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3pFYlFRQVlnQVRscE9wU05ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRVhqUWNBYXdCZkFGRUFSQUE1QUN3QUlZQUxTVzUyWVd4cFpDQmtZWGxKRlJaWEJnSk1VSUFFRlI5OGRVeFFzSUVCUTRBR1UzVnVaR0Y1UXYvaGdBaFRZWFIxY21SaGVVTC8xSUFHUm5KcFpHRjVRdi9KZ0FoVWFIVnljMlJoZVVML3ZJQUpWMlZrYm1WelpHRjVRdit1Z0FkVWRXVnpaR0Y1UXYraWdBWk5iMjVrWVhsQy81Yz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
