# CS_ARCH_AARCH64, 0, None
0x00,0x00,0x00,0x12 = and	w0, w0, #0x1
0x00,0x00,0x40,0x92 = and	x0, x0, #0x1
0x41,0x0c,0x00,0x12 = and	w1, w2, #0xf
0x41,0x0c,0x40,0x92 = and	x1, x2, #0xf
0xbf,0xec,0x7c,0x92 = and	sp, x5, #0xfffffffffffffff0
0x00,0x00,0x00,0x72 = ands	w0, w0, #0x1
0x00,0x00,0x40,0xf2 = ands	x0, x0, #0x1
0x41,0x0c,0x00,0x72 = ands	w1, w2, #0xf
0x41,0x0c,0x40,0xf2 = ands	x1, x2, #0xf
0x41,0x00,0x12,0x52 = eor	w1, w2, #0x4000
0x41,0x00,0x71,0xd2 = eor	x1, x2, #0x8000
0x41,0x00,0x12,0x32 = orr	w1, w2, #0x4000
0x41,0x00,0x71,0xb2 = orr	x1, x2, #0x8000
0xe8,0x03,0x00,0x32 = orr	w8, wzr, #0x1
0xe8,0x03,0x40,0xb2 = orr	x8, xzr, #0x1
0x41,0x00,0x03,0x0a = and	w1, w2, w3
0x41,0x00,0x03,0x8a = and	x1, x2, x3
0x41,0x08,0x03,0x0a = and	w1, w2, w3, lsl #2
0x41,0x08,0x03,0x8a = and	x1, x2, x3, lsl #2
0x41,0x08,0x43,0x0a = and	w1, w2, w3, lsr #2
0x41,0x08,0x43,0x8a = and	x1, x2, x3, lsr #2
0x41,0x08,0x83,0x0a = and	w1, w2, w3, asr #2
0x41,0x08,0x83,0x8a = and	x1, x2, x3, asr #2
0x41,0x08,0xc3,0x0a = and	w1, w2, w3, ror #2
0x41,0x08,0xc3,0x8a = and	x1, x2, x3, ror #2
0x41,0x00,0x03,0x6a = ands	w1, w2, w3
0x41,0x00,0x03,0xea = ands	x1, x2, x3
0x41,0x08,0x03,0x6a = ands	w1, w2, w3, lsl #2
0x41,0x08,0x03,0xea = ands	x1, x2, x3, lsl #2
0x41,0x08,0x43,0x6a = ands	w1, w2, w3, lsr #2
0x41,0x08,0x43,0xea = ands	x1, x2, x3, lsr #2
0x41,0x08,0x83,0x6a = ands	w1, w2, w3, asr #2
0x41,0x08,0x83,0xea = ands	x1, x2, x3, asr #2
0x41,0x08,0xc3,0x6a = ands	w1, w2, w3, ror #2
0x41,0x08,0xc3,0xea = ands	x1, x2, x3, ror #2
0x41,0x00,0x23,0x0a = bic	w1, w2, w3
0x41,0x00,0x23,0x8a = bic	x1, x2, x3
0x41,0x0c,0x23,0x0a = bic	w1, w2, w3, lsl #3
0x41,0x0c,0x23,0x8a = bic	x1, x2, x3, lsl #3
0x41,0x0c,0x63,0x0a = bic	w1, w2, w3, lsr #3
0x41,0x0c,0x63,0x8a = bic	x1, x2, x3, lsr #3
0x41,0x0c,0xa3,0x0a = bic	w1, w2, w3, asr #3
0x41,0x0c,0xa3,0x8a = bic	x1, x2, x3, asr #3
0x41,0x0c,0xe3,0x0a = bic	w1, w2, w3, ror #3
0x41,0x0c,0xe3,0x8a = bic	x1, x2, x3, ror #3
0x41,0x00,0x23,0x6a = bics	w1, w2, w3
0x41,0x00,0x23,0xea = bics	x1, x2, x3
0x41,0x0c,0x23,0x6a = bics	w1, w2, w3, lsl #3
0x41,0x0c,0x23,0xea = bics	x1, x2, x3, lsl #3
0x41,0x0c,0x63,0x6a = bics	w1, w2, w3, lsr #3
0x41,0x0c,0x63,0xea = bics	x1, x2, x3, lsr #3
0x41,0x0c,0xa3,0x6a = bics	w1, w2, w3, asr #3
0x41,0x0c,0xa3,0xea = bics	x1, x2, x3, asr #3
0x41,0x0c,0xe3,0x6a = bics	w1, w2, w3, ror #3
0x41,0x0c,0xe3,0xea = bics	x1, x2, x3, ror #3
0x41,0x00,0x23,0x4a = eon	w1, w2, w3
0x41,0x00,0x23,0xca = eon	x1, x2, x3
0x41,0x10,0x23,0x4a = eon	w1, w2, w3, lsl #4
0x41,0x10,0x23,0xca = eon	x1, x2, x3, lsl #4
0x41,0x10,0x63,0x4a = eon	w1, w2, w3, lsr #4
0x41,0x10,0x63,0xca = eon	x1, x2, x3, lsr #4
0x41,0x10,0xa3,0x4a = eon	w1, w2, w3, asr #4
0x41,0x10,0xa3,0xca = eon	x1, x2, x3, asr #4
0x41,0x10,0xe3,0x4a = eon	w1, w2, w3, ror #4
0x41,0x10,0xe3,0xca = eon	x1, x2, x3, ror #4
0x41,0x00,0x03,0x4a = eor	w1, w2, w3
0x41,0x00,0x03,0xca = eor	x1, x2, x3
0x41,0x14,0x03,0x4a = eor	w1, w2, w3, lsl #5
0x41,0x14,0x03,0xca = eor	x1, x2, x3, lsl #5
0x41,0x14,0x43,0x4a = eor	w1, w2, w3, lsr #5
0x41,0x14,0x43,0xca = eor	x1, x2, x3, lsr #5
0x41,0x14,0x83,0x4a = eor	w1, w2, w3, asr #5
0x41,0x14,0x83,0xca = eor	x1, x2, x3, asr #5
0x41,0x14,0xc3,0x4a = eor	w1, w2, w3, ror #5
0x41,0x14,0xc3,0xca = eor	x1, x2, x3, ror #5
0x41,0x00,0x03,0x2a = orr	w1, w2, w3
0x41,0x00,0x03,0xaa = orr	x1, x2, x3
0x41,0x18,0x03,0x2a = orr	w1, w2, w3, lsl #6
0x41,0x18,0x03,0xaa = orr	x1, x2, x3, lsl #6
0x41,0x18,0x43,0x2a = orr	w1, w2, w3, lsr #6
0x41,0x18,0x43,0xaa = orr	x1, x2, x3, lsr #6
0x41,0x18,0x83,0x2a = orr	w1, w2, w3, asr #6
0x41,0x18,0x83,0xaa = orr	x1, x2, x3, asr #6
0x41,0x18,0xc3,0x2a = orr	w1, w2, w3, ror #6
0x41,0x18,0xc3,0xaa = orr	x1, x2, x3, ror #6
0x41,0x00,0x23,0x2a = orn	w1, w2, w3
0x41,0x00,0x23,0xaa = orn	x1, x2, x3
0x41,0x1c,0x23,0x2a = orn	w1, w2, w3, lsl #7
0x41,0x1c,0x23,0xaa = orn	x1, x2, x3, lsl #7
0x41,0x1c,0x63,0x2a = orn	w1, w2, w3, lsr #7
0x41,0x1c,0x63,0xaa = orn	x1, x2, x3, lsr #7
0x41,0x1c,0xa3,0x2a = orn	w1, w2, w3, asr #7
0x41,0x1c,0xa3,0xaa = orn	x1, x2, x3, asr #7
0x41,0x1c,0xe3,0x2a = orn	w1, w2, w3, ror #7
0x41,0x1c,0xe3,0xaa = orn	x1, x2, x3, ror #7