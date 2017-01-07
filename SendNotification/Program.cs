using System;
using Microsoft.Azure.NotificationHubs;
using SendNotification.Helpers;

namespace SendNotification
{
    public sealed class Program
    {

        private static void Main(string[] args)
        {
            Console.ReadLine();
        }


        private static async void SendTileNotification(string message)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(ConfigureHelper.Connection, ConfigureHelper.HubName);

            string toast = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<tile>" +
                   "<visual>" +
                       "<binding template=\"TileSquareText04\">" +
                          "<text id=\"1\">" + message + "</text>" +
                       "</binding>" +
                   "</visual>" +
                "</tile>";

            await hub.SendWindowsNativeNotificationAsync(toast);
        }

        private static async void SendToastNotification(string message)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(ConfigureHelper.Connection, ConfigureHelper.HubName);

            string toast = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<toast>" +
                   "<visual>" +
                       "<binding template=\"ToastText01\">" +
                          "<text id=\"1\">" + message + "</text>" +
                       "</binding>" +
                   "</visual>" +
                "</toast>";

            await hub.SendWindowsNativeNotificationAsync(toast);
        }
    }
}