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

namespace Arc56.Generated.algorandfoundation.arc55_encryption.MsigApp_1e18bf57
{


    //
    // MsigApp - A contract that extends ARC55 functionality for multisig operations
    //
    public class MsigAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MsigAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy a new On-Chain Msig App.
        ///</summary>
        /// <param name="admin">Address of person responsible for calling `arc55_setup` </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the application
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Destroy the application and return funds to creator address.
        ///All transactions must be removed before calling destroy.
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXNpZ0FwcCIsImRlc2MiOiJNc2lnQXBwIC0gQSBjb250cmFjdCB0aGF0IGV4dGVuZHMgQVJDNTUgZnVuY3Rpb25hbGl0eSBmb3IgbXVsdGlzaWcgb3BlcmF0aW9ucyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJEZXBsb3kgYSBuZXcgT24tQ2hhaW4gTXNpZyBBcHAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOiJBZGRyZXNzIG9mIHBlcnNvbiByZXNwb25zaWJsZSBmb3IgY2FsbGluZyBgYXJjNTVfc2V0dXBgIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJNc2lnIEFwcCBBcHBsaWNhdGlvbiBJRCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IlVwZGF0ZSB0aGUgYXBwbGljYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkRlc3Ryb3kgdGhlIGFwcGxpY2F0aW9uIGFuZCByZXR1cm4gZnVuZHMgdG8gY3JlYXRvciBhZGRyZXNzLlxuQWxsIHRyYW5zYWN0aW9ucyBtdXN0IGJlIHJlbW92ZWQgYmVmb3JlIGNhbGxpbmcgZGVzdHJveS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBEZWxldGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgVXBkYXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2N2YlhOcFp5NWhjSEF1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXphV2RCY0hBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5EWm1OelkxTXpNZ01IZ3lORGczWXpNeVl5QXdlR1F6TWpSaVpXRTBJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z3WkdGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFESWdiV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6SUcxaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU5Bb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXY3ZiWE5wWnk1aGNIQXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZV1J0YVc0NklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQmlJR055WldGMFpVRndjR3hwWTJGMGFXOXVDZ3B0WVdsdVgyUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2N2YlhOcFp5NWhjSEF1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnWkdWc1pYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVDZ3B0WVdsdVgzVndaR0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2N2YlhOcFp5NWhjSEF1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJSFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuTDIxemFXY3VZWEJ3TG1Gc1oyOHVkSE02T2sxemFXZEJjSEF1WTNKbFlYUmxRWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaeTl0YzJsbkxtRndjQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWhoWkcxcGJqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdjdmJYTnBaeTVoY0hBdVlXeG5ieTUwY3pvNlRYTnBaMEZ3Y0M1MWNHUmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuTDIxemFXY3VZWEJ3TG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUhSb2FYTXViMjVzZVVGa2JXbHVLQ2s3Q2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxCWkcxcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuTDIxemFXY3VZWEJ3TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFp5OXRjMmxuTG1Gd2NDNWhiR2R2TG5Sek9qcE5jMmxuUVhCd0xtUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdjdmJYTnBaeTVoY0hBdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVFXUnRhVzRvS1RzS0lDQWdJR05oYkd4emRXSWdiMjVzZVVGa2JXbHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdjdmJYTnBaeTVoY0hBdVlXeG5ieTUwY3pvME5DMDBPUW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuTDIxemFXY3VZWEJ3TG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWnk5dGMybG5MbUZ3Y0M1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeHZjMlZTWlcxaGFXNWtaWEpVYndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsbkwyMXphV2N1WVhCd0xtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsbkwyMXphV2N1WVhCd0xtRnNaMjh1ZEhNNk5EUXRORGtLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2N2YlhOcFp5NWhjSEF1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdjdmJYTnBaeTVoY0hBdVlXeG5ieTUwY3pvME5DMDBPUW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWnk5dGMybG5MbUZ3Y0M1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCa1pXeGxkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXY3ZiWE5wWnk1aGNIQXVZV3huYnk1MGN6bzZUWE5wWjBGd2NDNXZibXg1UVdSdGFXNG9LU0F0UGlCMmIybGtPZ3B2Ym14NVFXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXY3ZiWE5wWnk1aGNIQXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUVkc2IySmhiQzVqY21WaGRHOXlRV1JrY21WemN5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUNDQXdSRzkyVXpCQ1NId3l3RTB5UytwRFlhQUk0REFCZ0FEQUFCQURFWkZERVlGQkJFUWdBWU1SbUJCUkl4R0JCRVFnQWJNUm1CQkJJeEdCQkVRZ0FLTmhvQkZZRWdFa1FpUTRnQUdTSkRpQUFVc1RJSlNiSUpzZ2Nqc2dnaXNoQWpzZ0d6SWtNeEFESUpFa1NKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
