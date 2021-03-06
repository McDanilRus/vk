﻿using System;
using System.Net;
using VkNet.Enums.Filters;

namespace VkNet.Utils
{
    /// <summary>
    /// Интерфейс браузера, с помощью которого осуществляется сетевое взаимодействие.
    /// Интерфейс введен с целью обеспечения возможности выполнения модульного тестирования.
    /// </summary>
    public interface IBrowser
    {
        /// <summary>
        /// Выполняет JSON-запрос к ВКонтакте.
        /// </summary>
        /// <param name="url">URL, в котором закодированы параметры запроса.</param>
        /// <returns>Результат выполнения запроса, полученный от сервера в формате JSON.</returns>
        string GetJson(string url);

        /// <summary>
        /// Выполняет авторизацию ВКонтакте.
        /// Если приложение с идентификатором <paramref name="appId"/> не было установлено у пользователя, имеющего
        /// логин <paramref name="email"/>, то производится его установка с разрешениями <paramref name="settings"/>.
        /// </summary>
        /// <param name="appId">Идентификатор авторизуемого приложения.</param>
        /// <param name="email">Логин пользователя ВКонтакте (его почта).</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <param name="settings">Запрашиваемые для работы разрешения.</param>
        /// <param name="code">Провайдер кода для двух факторной авторизации.</param>
        /// <param name="captchaSid">Идентификатор капчи</param>
        /// <param name="captchaKey">Текст капчи.</param>
        /// <param name="webProxy">Web прокси</param>
        /// <returns>
        /// Информация об авторизации приложения.
        /// </returns>
        VkAuthorization Authorize(ulong appId, string email, string password, Settings settings, Func<string> code, long? captchaSid, string captchaKey, IWebProxy webProxy = null);
    }
}