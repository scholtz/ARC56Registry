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

namespace Arc56.Generated.nickthelegend.puya_algo_ts_smartcontracts.SingleAgentContract_4aa690d6
{


    public class SingleAgentContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SingleAgentContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentName"> </param>
        /// <param name="agentDetails"> </param>
        /// <param name="pricing"> </param>
        /// <param name="managerAppId"> </param>
        public async Task CreateApplication(string agentName, string agentDetails, ulong pricing, ulong managerAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 147, 103, 9 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentDetailsAbi.From(agentDetails);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);
            var managerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); managerAppIdAbi.From(managerAppId);

            var result = await base.CallApp(new List<object> { abiHandle, agentNameAbi, agentDetailsAbi, pricingAbi, managerAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(string agentName, string agentDetails, ulong pricing, ulong managerAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 147, 103, 9 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentDetailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentDetailsAbi.From(agentDetails);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);
            var managerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); managerAppIdAbi.From(managerAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentNameAbi, agentDetailsAbi, pricingAbi, managerAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2luZ2xlQWdlbnRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50RGV0YWlscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2luZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOcGJtZHNaVUZuWlc1MFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTRPVE0yTnpBNUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGFXNW5iR1ZCWjJWdWRFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHbHVkQ0F3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVTJsdVoyeGxRV2RsYm5SRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEM1aGJHZHZMblJ6T2pwVGFXNW5iR1ZCWjJWdWRFTnZiblJ5WVdOMExtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtHRm5aVzUwVG1GdFpUb2dZbmwwWlhNc0lHRm5aVzUwUkdWMFlXbHNjem9nWW5sMFpYTXNJSEJ5YVdOcGJtYzZJSFZwYm5RMk5Dd2diV0Z1WVdkbGNrRndjRWxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk5EQXROREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvWVdkbGJuUk9ZVzFsT2lCemRISnBibWNzSUdGblpXNTBSR1YwWVdsc2N6b2djM1J5YVc1bkxDQndjbWxqYVc1bk9pQjFhVzUwTmpRc0lHMWhibUZuWlhKQmNIQkpaRG9nZFdsdWREWTBJRDBnTUNCaGN5QjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUc5M2JtVnlRV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW05M2JtVnlRV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUIwYUdsekxtOTNibVZ5UVdSa2NtVnpjeTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEk3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUc1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0NrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW01aGJXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnZEdocGN5NXVZVzFsTG5aaGJIVmxJRDBnWVdkbGJuUk9ZVzFsT3dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHUmxkR0ZwYkhNZ1BTQkhiRzlpWVd4VGRHRjBaVHh6ZEhKcGJtYytLQ2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbVJsZEdGcGJITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnZEdocGN5NWtaWFJoYVd4ekxuWmhiSFZsSUQwZ1lXZGxiblJFWlhSaGFXeHpPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUdacGVHVmtVSEpwWTJsdVp5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpWm1sNFpXUlFjbWxqYVc1bklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSFJvYVhNdVptbDRaV1JRY21samFXNW5MblpoYkhWbElEMGdjSEpwWTJsdVp6c0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJqY21WaGRHVmtRWFFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTnlaV0YwWldSQmRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxtTnlaV0YwWldSQmRDNTJZV3gxWlNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEE3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUmhjMnREYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpZEdGemEwTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIUm9hWE11ZEdGemEwTnZkVzUwTG5aaGJIVmxJRDBnTUNCaGN5QjFhVzUwTmpRN0NpQWdJQ0J3ZFhOb2FXNTBJREFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJOUVU1QlIwVlNYMEZRVUY5SlJDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpVFVGT1FVZEZVbDlCVUZCZlNVUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblF1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnZEdocGN5NU5RVTVCUjBWU1gwRlFVRjlKUkM1MllXeDFaU0E5SUcxaGJtRm5aWEpCY0hCSlpEc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDakViUVFBTmdBUUlrMmNKTmhvQWpnRUFBNEVBUXpFWkZFUXhHQlJFTmhvQlZ3SUFOaG9DVndJQU5ob0RGellhQkJlSUFBT0JBVU9LQkFDQURHOTNibVZ5UVdSa2NtVnpjekVBWjRBRWJtRnRaWXY4WjRBSFpHVjBZV2xzYzR2OVo0QU1abWw0WldSUWNtbGphVzVuaS81bmdBbGpjbVZoZEdWa1FYUXlCMmVBQ1hSaGMydERiM1Z1ZElFQVo0QU9UVUZPUVVkRlVsOUJVRkJmU1VTTC8yZUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
