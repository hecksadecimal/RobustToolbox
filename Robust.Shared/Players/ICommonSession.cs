﻿using Robust.Shared.Enums;

namespace Robust.Shared.Players
{
    /// <summary>
    ///     Common info between client and server sessions.
    /// </summary>
    public interface ICommonSession : IBaseSession
    {
        /// <summary>
        ///     Status of the session.
        /// </summary>
        SessionStatus Status { get; set; }
    }
}
