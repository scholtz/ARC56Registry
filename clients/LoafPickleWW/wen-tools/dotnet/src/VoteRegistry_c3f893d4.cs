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

namespace Arc56.Generated.LoafPickleWW.wen_tools.VoteRegistry_c3f893d4
{


    public class VoteRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VoteRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm90ZVJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aGNtTTBMMmx1WkdWNExtUXVkSE02T2tOdmJuUnlZV04wTG1Gd2NISnZkbUZzVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlXYjNSbFZHOXZiQzVoYkdkdkxuUnpPakV5TXkweE1qUUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJR0YyYlZabGNuTnBiMjQ2SURFeklIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVm05MFpWSmxaMmx6ZEhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlZtOTBaVlJ2YjJ3dVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlXYjNSbFZHOXZiQzVoYkdkdkxuUnpPanBXYjNSbFVtVm5hWE4wY25rdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVdiM1JsVkc5dmJDNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdabUZqZEc5eWVTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RtWVdOMGIzSjVKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ptWVdOMGIzSjVJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMVp2ZEdWVWIyOXNMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUIwYUdsekxtWmhZM1J2Y25rdWRtRnNkV1VnUFNCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKWkFvZ0lDQWdaMnh2WW1Gc0lFTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZWbTkwWlZSdmIyd3VZV3huYnk1MGN6b3hNekVLSUNBZ0lDOHZJRzl3TGtGd2NGQmhjbUZ0YzFObGRDNWhjSEJHWVcxcGJIbENiM2hCWTJObGMzTW9kSEoxWlNrS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ1lYQndYM0JoY21GdGMxOXpaWFFnUVhCd1JtRnRhV3g1UW05NFFXTmpaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Vm05MFpWUnZiMnd1WVd4bmJ5NTBjem94TXpNS0lDQWdJQzh2SUc5d0xrRndjRkJoY21GdGMxTmxkQzVoY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1vZEhKMVpTa0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTl6WlhRZ1FYQndSbTl5WldsbmJrSnZlRkpsWVdSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlZtOTBaVlJ2YjJ3dVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRFlBRXVFUjdOallhQUk0QkFBRUFNUmtVTVJnVUVFUkNBSUFIWm1GamRHOXllVElOWjRFQmRneUJBWFlMZ1FGRCIsImNsZWFyIjoiRFlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
